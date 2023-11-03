using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAction : MonoBehaviour
{
    Rigidbody rb;
    float force;
    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        force = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public void FixedUpdate() {
        rb.AddForce(Vector3.up * force);
    }
    public void OnPointerEnter() {
        force = 30;
    }
    public void OnPointerExit() {
        force = 0;
    }
}
