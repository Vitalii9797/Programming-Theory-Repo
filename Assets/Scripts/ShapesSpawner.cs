using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] shapesPrefabs;

    private float spawnPosX = 4f;
    private float spawnPosZ = 3f;
    private float spawnPosY = 10f;
    private float spawnRate = 1f;
    void Start()
    {
        StartCoroutine(SpawnShapes(spawnRate));
    }

    private IEnumerator SpawnShapes(float delay)
    {
        while(true)
        {
            yield return new WaitForSeconds(delay);
            Instantiate(GetRandomShape(), GetRandomSpawnPosition(), Quaternion.identity);
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        float posX = Random.Range(-spawnPosX, spawnPosX);
        float posZ = Random.Range(-spawnPosZ, spawnPosZ);

        return new Vector3(posX, spawnPosY, posZ);
    }

    private GameObject GetRandomShape()
    {
        return shapesPrefabs[Random.Range(0, shapesPrefabs.Length)];
    }
}
