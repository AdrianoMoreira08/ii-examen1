using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPointer : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje OnPointerEnter;
    // public event 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, transform.forward)) {
            OnPointerEnter();
        }
    }
}
