using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int numberOfCopies = 50;
    public float innerRadius = 400;
    public float outerRadius = 470;
    public float yValue = -15f;
    //public float x1 = 0f; // Center x position of the circular region
    //public float z1 = 0f; // Center z position of the circular region

    void Start()
    {
        for (int i = 0; i < numberOfCopies; i++)
        {
            Vector2 randomPositionXZ = Random.insideUnitCircle.normalized * Random.Range(innerRadius, outerRadius);
            Vector3 spawnPosition = new Vector3(randomPositionXZ.x, yValue, randomPositionXZ.y);
            //Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            Instantiate(objectToSpawn, spawnPosition, objectToSpawn.transform.rotation);
        }
    }
}


