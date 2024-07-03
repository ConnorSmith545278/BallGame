using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject anchor;
    [SerializeField] private Vector3 velocity = Vector3.zero;
    [SerializeField] private float smoothTime;

    // Update is called once per frame
    void Update()
    {
        //the camera smoothly follows the anchorn using SmoothDamp.
        if(anchor != null)
       transform.position = Vector3.SmoothDamp(transform.position, anchor.transform.position, ref velocity, smoothTime);
    }
}
