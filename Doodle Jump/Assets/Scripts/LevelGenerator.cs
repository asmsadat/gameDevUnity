using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatform = 200;
    public float levelWidth = 3f;
    public float minY = 0.2f;
    public float maxY = 1.5f;

    void Start()
    {
        Vector3  spawnPosition = new Vector3();

        for(int i = 0; i < numberOfPlatform; i++)
        {
            spawnPosition.y += Random.Range(maxY, minY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
