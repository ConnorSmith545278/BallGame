using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject anchor;
    [SerializeField] private Vector3 velocity = Vector3.zero;
    [SerializeField] private float smoothTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(anchor != null)
       transform.position = Vector3.SmoothDamp(transform.position, anchor.transform.position, ref velocity, smoothTime);
    }
}
