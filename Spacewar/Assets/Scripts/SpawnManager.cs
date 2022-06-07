using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public GameManager gameManager;
    private float startSpawn = 3.0f;
    private float spawnDelay = 2.0f;
    private float xRange = 12.0f;
    private float zRange = 17.0f;
    private float yRange = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("enemySpawner", startSpawn, spawnDelay);
    }

    void FixedUpdate()
    {

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
