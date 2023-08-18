using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float topSpawnRangeX = 10f;
    [SerializeField] private float topSpawnPosZ = 20f;
    [SerializeField] private float sideSpawnPosX = 24f;
    [SerializeField] private float sideSpawnRangeZ = 15f;
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalTop", startDelay, spawnInterval);    
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnRandomAnimalTop()
    {
        // Spawn random animal at random location inside the spawn range
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-topSpawnRangeX, topSpawnRangeX), 0, topSpawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    private void SpawnRandomAnimalLeft()
    {
        // Spawn random animal at random location inside the spawn range
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnPosX, 0, Random.Range(0, sideSpawnRangeZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));
    }

    private void SpawnRandomAnimalRight()
    {
        // Spawn random animal at random location inside the spawn range
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnPosX, 0, Random.Range(0, sideSpawnRangeZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 270, 0));
    }
}
