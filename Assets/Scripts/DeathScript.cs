using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    [SerializeField] private float deathValue;
    [SerializeField] private GameObject endScreen;
    [SerializeField] private GameObject startScreen;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deathValue)
        {
            Instantiate(endScreen);
            Destroy(gameObject);
        }
    }
}
