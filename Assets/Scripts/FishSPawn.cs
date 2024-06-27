using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSPawn : MonoBehaviour
{
    // The horizontal range
    public float horizontalRange = 10f;

    // The vertical range
    public float verticalRange = 5f;

    [System.Serializable]
    public class FishData
    {
        public GameObject Fish;
        public int numberOfObjects;
        public float size;
    }

    public FishData[] fishData;

    private void Start()
    {
        SpawnObjects();
    }

    private void SpawnObjects()
    {
        for(int e = 0; e < fishData.Length; e++)
        {
            for (int i = 0; i < fishData[e].numberOfObjects; i++)
            {
                // Generate random position within the specified ranges
                float randomX = Random.Range(-horizontalRange, horizontalRange);
                float randomY = Random.Range(-verticalRange, verticalRange);

                Vector2 randomPosition = new Vector2(randomX, randomY);

                // Instantiate the object at the random position
                Instantiate(fishData[e].Fish, randomPosition, Quaternion.identity, transform).GetComponent<Transform>().localScale = new Vector3(fishData[e].size, fishData[e].size, fishData[e].size);
            }
        }
    }
}
