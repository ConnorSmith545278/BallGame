using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terraindestroyer : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private Rigidbody playerrb; 
    [SerializeField] private float acceleration;
    [SerializeField] private float slowDown = 0.1f;
    [SerializeField] private float speedUp = 2;
    private float startPositionPlayerZ;
    private bool started = false;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerrb = player.GetComponent<Rigidbody>();
        startPositionPlayerZ = player.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            if (!started)
            {
                if (startPositionPlayerZ < player.transform.position.z)
                {
                    started = true;
                }
            }

            if (playerrb.velocity.z < rb.velocity.z)
            {
                acceleration = slowDown;
            }
            else
            {
                acceleration = speedUp;
            }
        }
    }

    private void FixedUpdate()
    {
        if (started)
        {
            rb.AddForce(0, 0, acceleration);
        }
    }
}
