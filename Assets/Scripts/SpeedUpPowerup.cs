using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class SpeedUpPowerup : MonoBehaviour
{
    [SerializeField] float forwardMultiplier;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<Movement>().forwardMultiplier += forwardMultiplier;
            Destroy(gameObject);
        }
    }
}
