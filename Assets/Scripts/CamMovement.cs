using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    private Vector3 startDistance;
    private GameObject player;
    private Rigidbody playerrb;
    [SerializeField] private float moveFactor;

    [SerializeField] Camera cam;
    CamFollow camFollow;
    [SerializeField] GameObject upperAnchor;
    [SerializeField] GameObject terrainDestroyer;
    [SerializeField] private float upperOffset;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        startDistance = transform.position- player.transform.position;
        playerrb = player.GetComponent<Rigidbody>();
        camFollow = cam.GetComponent<CamFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerrb != null && player != null)
        {
            if (playerrb.velocity.z < 0)
            {
                transform.position = player.transform.position + startDistance;
            }
            else
            {
                transform.position = player.transform.position + startDistance + (startDistance * (playerrb.velocity.z / moveFactor));
            }
        }

        if (upperAnchor.transform.position.z < terrainDestroyer.transform.position.z + upperOffset)
        {
            camFollow.anchor = upperAnchor;
        }
        else
        {
            camFollow.anchor = gameObject;
        }
    }
}
