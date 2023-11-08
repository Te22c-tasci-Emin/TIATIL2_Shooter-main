using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]

GameObject spawner;
public class powerupSpawner : MonoBehaviour
{
    float timeBetweenEnemies = 0.5f;    
   float timeSinceLastEnemies = 0;
    void Update()
    {
         timeSinceLastEnemies += Time.deltaTime;

        if (timeSinceLastEnemies > timeBetweenEnemies)
        {
        Instantiate(spawner);
        timeSinceLastEnemies = 0;
        }
    }
}