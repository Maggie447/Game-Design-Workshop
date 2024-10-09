using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnRangeX = 16.0f;
    private float spawnRangeMinZ = 0.0f;
    private float spawnRangeMaxZ = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn 25 balls
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
        Invoke("SpawnRandomBalls", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomBalls()
    {
        // Spawn random balls at random locations
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), -0.5f, Random.Range(spawnRangeMinZ, spawnRangeMaxZ));

        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
