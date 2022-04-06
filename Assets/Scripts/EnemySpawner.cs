using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Enemy;
    public float limit;
    private float lastSpawnTime = Mathf.NegativeInfinity;
    public float spawnDelay = 3f;

    // Update is called once per frame
    void Update()
    {
        checkSpawnerTime();
  
    }

    private void checkSpawnerTime()
    {
        if(Time.timeSinceLevelLoad > lastSpawnTime + spawnDelay)//&& (currentlySpawned < maxSpawn))
        {
            spawnEnemy();
        }
    }

    private void spawnEnemy()
    {
            GameObject newEnemy = Instantiate(Enemy);
            newEnemy.transform.position = transform.position + new Vector3(Random.Range(-limit,limit),0,0);
            lastSpawnTime = Time.timeSinceLevelLoad;
    }
}
