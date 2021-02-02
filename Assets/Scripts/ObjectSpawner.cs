using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject[] trianglePrefabs;
    [SerializeField] float distanceBetweenObstacles = 20f;
    Vector3 obstacleSpawnPosition;
    
    // Update is called once per frame
    void Update()
    {
        float distanceToHorizon = Vector3.Distance(player.transform.position, obstacleSpawnPosition);
        if (distanceToHorizon < 120)
        {
            SpawnTriangles();
        }
    }

    private void SpawnTriangles()
    {
        obstacleSpawnPosition = new Vector3(0, 0, obstacleSpawnPosition.z + distanceBetweenObstacles);
        Instantiate(trianglePrefabs[Random.Range(0,trianglePrefabs.Length)], obstacleSpawnPosition, Quaternion.identity);
    }
}
