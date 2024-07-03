using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Movement : MonoBehaviour
{
    public float acceleration;
    private Rigidbody rb;
    public float horizontalMultiplier =1;
    public float forwardMultiplier = 1;
    public float maxSpeed;
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        //set stats as last level
        if(gm != null)
        {
            if(gm.forwardStat != 0)
            {
                forwardMultiplier = gm.forwardStat;
                horizontalMultiplier = gm.horizontalStat;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float resistance = -(rb.velocity.z / maxSpeed) + 1;
        Vector3 moveVector = new Vector3(Input.GetAxis("Horizontal") * horizontalMultiplier, 0, Input.GetAxis("Vertical") * resistance * forwardMultiplier);
        if (moveVector.z < 0)
        {
            moveVector.z = 0;
        }
        rb.AddForce(moveVector*acceleration);
    }
    private void OnDestroy()
    {
        if(gm != null)
        {
            gm.forwardStat = forwardMultiplier;
            gm.horizontalStat = horizontalMultiplier;
        }
    }
}
