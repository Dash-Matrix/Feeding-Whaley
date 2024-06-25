using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSPawn : MonoBehaviour
{
    // The prefab to spawn
    public GameObject objectToSpawn;

    // The number of objects to spawn
    public int numberOfObjects = 10;

    // The horizontal range
    public float horizontalRange = 10f;

    // The vertical range
    public float verticalRange = 5f;

    private void Start()
    {
        SpawnObjects();
        methid(numberOfObjects);
    }

    private void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Generate random position within the specified ranges
            float randomX = Random.Range(-horizontalRange, horizontalRange);
            float randomY = Random.Range(-verticalRange, verticalRange);

            Vector2 randomPosition = new Vector2(randomX, randomY);

            // Instantiate the object at the random position
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity, transform);
        }
    }

    private void methid(int i)
    {
        i++;
        Debug.Log("My Number" + i);
    }
}
