using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    private Vector3 distance;
    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
        distance = transform.position- target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + distance;
    }
}
