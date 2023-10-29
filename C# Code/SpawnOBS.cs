using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOBS : MonoBehaviour
{
    public GameObject[] obstaclePrefab; // The prefab of the obstacle to spawn
    public float spawnInterval = 2.0f; // The time interval between spawns
    public Transform spawnPoint1; // The spawn point at (x=5, y=0)
    public Transform spawnPoint2; // The spawn point at (x=3, y=0)

    private void Start()
    {
        
        // Start spawning obstacles
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
       
        
            while (true) // Infinite loop for endless spawning
            {
                // Randomly choose a spawn point (1 or 2)
                int randomSpawnPoint = Random.Range(1, 3);
                int rand = Random.Range(0, obstaclePrefab.Length);

            if (FindObjectOfType<GameManager>().isGAmeStart == true) 
            {
                // Spawn an obstacle at the chosen spawn point
                if (randomSpawnPoint == 1)
                {
                    Instantiate(obstaclePrefab[rand], spawnPoint1.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(obstaclePrefab[rand], spawnPoint2.position, Quaternion.identity);
                }
            }
                

                yield return new WaitForSeconds(spawnInterval); // Wait for the specified interval before the next spawn
            }
        
       
    }

}
