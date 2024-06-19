using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terraindestroyer : MonoBehaviour
{
    private GameObject player;
    private Vector3 playerPosition;
    private Rigidbody rb;
    [SerializeField] private float speed;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, speed);
    }
}
