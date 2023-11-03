using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChairTable : MonoBehaviour
{
    // Start is called before the first frame update
    Transform chair;
    Transform table;
    Vector3 position;
    Vector3 direction;
    Vector3 chair_loc;
    Rigidbody rb;
    public float speed;
    public float minDist;
    string currentObject;

    void Start()
    {
        chair = GameObject.Find("ExeciseChair1").transform;
        table = GameObject.Find("ExerciseTable1").transform;
        rb = GetComponent<Rigidbody>();
        position = chair.position;
        currentObject = "chair";
        speed = -15f;
        minDist = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Debug.Log(Vector3.Distance(position, transform.position) < minDist);
        Debug.Log(currentObject);
        // if (Vector3.Distance(position, transform.position) < minDist) {
        //     if (currentObject == "chair") {
        //         currentObject = "table";
        //         position = table.position;
        //     } else {
        //         currentObject = "chair";
        //         position = chair.position;
        //     }
        // }
        direction = Vector3.Normalize(position - transform.position);
        rb.AddForce(direction * speed);
    }
    void SwitchPos() {
        if (currentObject == "chair") {
            currentObject = "table";
            position = table.position;
        }
        currentObject = "chair";
        position = chair.position;
    }

    void OnColliderEnter(Collider other) {
        Debug.Log("COLLIDING");
        if (other.name == "ExeciseChair1") {
            position = -table.position;
        } else if (other.name == "ExeciseTable1") {
            position = chair.position;
        }

    }
}
