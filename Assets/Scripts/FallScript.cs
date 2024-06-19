using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{   
    [SerializeField] private Material Material;
    [SerializeField] private Material FallingMaterialDark;
    [SerializeField] private Material FallingMaterialLight;
    [SerializeField] private Material lightGreen;
    private bool falling = false;
    private float fallTime = 3;
    private Rigidbody rb;
    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();

        if(Material == null || FallingMaterialDark == null  || FallingMaterialLight== null)
        {
            Debug.Log("Error. Missing material on" + gameObject);
        }
        Debug.Log(name + " => " + renderer.material.name);
        //Debug.Log(lightGreen.name);
    }

    // Update is called once per frame
    void Update()
    {
        if(falling)
        {
            fallTime -= Time.deltaTime;
        }
        if(fallTime < 0.0f)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "TerrainDestroyer")
        {
            if ( ! falling )
            {
                string materinal_name = renderer.material.name.Replace( " (Instance)", "");
                //if (materinal_name.Equals( lightGreen.name ) )
                if (renderer.material.color == lightGreen.color)
                {
                    Debug.Log(name + " ? '" + lightGreen.name + "' == '" + materinal_name + "' to " + FallingMaterialLight.name );
                    renderer.material = FallingMaterialLight;
                }
                else
                {
                    Debug.Log(name + " ? '" + lightGreen.name + "' != '" + materinal_name + "' to " + FallingMaterialDark.name);
                    renderer.material = FallingMaterialDark;
                }
                falling = true;
            }
        }
    }
}
