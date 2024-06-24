using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class SpeedUpPowerup : MonoBehaviour
{
    [SerializeField] float forwardMultiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<Movement>().forwardMultiplier += forwardMultiplier;
            Destroy(gameObject);
        }
    }
}
