using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerrainBuilder : MonoBehaviour
{
    [SerializeField] private GameObject defaultTerrain;
    [SerializeField] private float terrainSize;
    [SerializeField] private int terrainAmount;
    [SerializeField] private GameObject[] Obstacles;
    [SerializeField] private GameObject finish;
    private GameObject chosenObject;
    private GameObject previousObject;

    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < terrainAmount; i++)
        {
            if (i == terrainAmount - 1)
            {
                Instantiate(finish, new Vector3(transform.position.x, transform.position.y, transform.position.z + terrainSize * i), Quaternion.identity);
            }
            else
            {
                spawnObstacle(i);
            }
        }
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
            Instantiate(chosenObject, new Vector3(transform.position.x, transform.position.y, transform.position.z + terrainSize * i), Quaternion.identity);
            previousObject = chosenObject;
        }
    }
}
