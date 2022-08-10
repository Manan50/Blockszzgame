using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockspawner : MonoBehaviour
{
    public static blockspawner instance;

    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    
    private float timeToSpawn = 2f;
    private float interval = 1.5f;

    


    public void Awake()
    {
        MakeInstance();
    }
        void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + interval;

           
        }
    }
    
    public void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);

            }

        }
    }
    void MakeInstance()
    {
        if (instance == null)
        {

            instance = this;
        }

    }

}
