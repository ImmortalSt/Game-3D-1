using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplerManager : MonoBehaviour
{
    [SerializeField]
    public GameObject applePrefab;
    public Vector3 spawnAreaSize = new Vector3(100f, 0f, 100f);

    void Start()
    {
        StartCoroutine(SpawnApples(1f));
    }

    IEnumerator SpawnApples(float interval)
    {
        while (true)
        {
            SpawnApple();
            yield return new WaitForSeconds(interval);
        }
    }

    void SpawnApple()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),  // x
            1f,                                                       // y
            Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)   // z
        );

        Instantiate(applePrefab, randomPosition, Quaternion.identity);
    }

}

