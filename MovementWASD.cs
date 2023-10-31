using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWASD : MonoBehaviour
{
    public float speed = 3f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * Input.GetAxis("Vertical") * speed);
        rb.AddForce(Vector3.right * Input.GetAxis("Horizontal") * speed);
        rb.AddForce(Vector3.up * Input.GetAxis("Jump") * speed);
    }
}
