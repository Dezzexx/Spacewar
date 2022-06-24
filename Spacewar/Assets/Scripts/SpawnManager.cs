using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public GameManager gameManager;
    
    [SerializeField] float startSpawn = 3.0f;
    [SerializeField] float spawnDelay = 2.0f;
    
    [SerializeField] float xRange = 12.0f;
    [SerializeField] float zRange = 17.0f;
    [SerializeField] float yRange = 1.0f;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("enemySpawner", startSpawn, spawnDelay);
    }

    void enemySpawner()
    {
        if (gameManager.isGameActive)
        {
            int randomEnemy = Random.Range(0, enemyPrefab.Length);
            Vector3 position = new Vector3(Random.Range(-xRange, xRange), yRange, zRange);
            Instantiate(enemyPrefab[randomEnemy], position, transform.rotation);
        }
    }
}
