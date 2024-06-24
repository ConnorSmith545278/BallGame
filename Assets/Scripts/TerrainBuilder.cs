using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TerrainBuilder : MonoBehaviour
{
    [SerializeField] private GameObject defaultTerrain;
    [SerializeField] private float terrainSize;
    [SerializeField] private int terrainAmount;
    [SerializeField] private GameObject[] Obstacles;
    private GameObject chosenObject;
    private GameObject previousObject;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < terrainAmount; i++)
        {
            spawnObstacle(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void spawnObstacle(int i)
    {
        chosenObject = Obstacles[Random.Range(0, Obstacles.Length)];
        if (chosenObject == previousObject)
        {
            spawnObstacle(i);
        }
        else
        {
            Debug.Log(chosenObject);
            Instantiate(chosenObject, new Vector3(transform.position.x, transform.position.y, transform.position.z + terrainSize * i), Quaternion.identity);
            previousObject = chosenObject;
        }
    }
}
