using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float acceleration;
    private Rigidbody rb;
    public float horizontalMultiplier =1;
    public float forwardMultiplier = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal") * horizontalMultiplier, 0, Input.GetAxis("Vertical") * forwardMultiplier);
        if (moveVector.z < 0)
        {
            moveVector.z = 0;
        }
        rb.AddForce(moveVector*acceleration);
    }
}
