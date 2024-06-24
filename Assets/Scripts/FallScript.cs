using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{   
    [SerializeField] private Material DeadMaterial;
    [SerializeField] private Material FallingMaterialDark;
    [SerializeField] private Material FallingMaterialLight;
    [SerializeField] private Material lightGreen;
    private bool falling = false;
    private float fallTime = 2;
    private Rigidbody rb;
    private Renderer renderer;
    [SerializeField] private float deletePoint = -20;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();

        if(DeadMaterial == null || FallingMaterialDark == null  || FallingMaterialLight== null)
        {
            Debug.Log("Error. Missing material on" + gameObject);
        }
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
            renderer.material = DeadMaterial; 
            if(transform.position.y < deletePoint)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "TerrainDestroyer")
        {
            if ( ! falling )
            {
                //Removes the "Instance" part of a material's name so it's compatable with checking names. Then depending on name, chooses a material.
                string materinal_name = renderer.material.name.Replace( " (Instance)", "");
                if (renderer.material.color == lightGreen.color)
                {
                    renderer.material = FallingMaterialLight;
                }
                else
                {
                    renderer.material = FallingMaterialDark;
                }
                falling = true;
            }
        }
    }
}
