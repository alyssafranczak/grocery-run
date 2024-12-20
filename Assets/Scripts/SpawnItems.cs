using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject itemApple;
    public GameObject itemOrange;
    public GameObject itemBanana;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;

    public float firstDelay;
    private float spawnTime;

    void Start()
    {
        // Initialize spawnTime with an offset of 0.4 seconds
        spawnTime = Time.time + firstDelay;
    }

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
                Instantiate(itemApple, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 2:
                Instantiate(itemOrange, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
            case 3:
                Instantiate(itemBanana, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
                break;
        }
    }
}
