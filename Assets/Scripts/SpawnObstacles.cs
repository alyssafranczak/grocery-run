using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacleSC;
    public GameObject obstacleOL;
    public GameObject obstaclePD;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime) {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        int randomNumber = Random.Range(1, 4);

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        switch (randomNumber)
        {
            case 1:
                Instantiate(obstacleSC, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 2:
                Instantiate(obstacleOL, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 3:
                Instantiate(obstaclePD, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
        }
    }
}
