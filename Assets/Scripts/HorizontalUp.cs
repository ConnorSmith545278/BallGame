using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalUp : MonoBehaviour
{
    [SerializeField] private float horizontalUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<Movement>().horizontalMultiplier += horizontalUp;
            Destroy(gameObject);
        } 
    }
}
