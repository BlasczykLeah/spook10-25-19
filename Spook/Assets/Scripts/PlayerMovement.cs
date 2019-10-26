using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hSpeed = Input.GetAxisRaw("Horizontal");
        float vSpeed = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(hSpeed * speed, vSpeed * speed);
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.FloorToInt(transform.position.y * 2));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            Debug.Log("hit");
        }
    }
}
