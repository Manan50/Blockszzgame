using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlowDownPowerup : MonoBehaviour
{
    bool playeralive = true;
    public GameObject player;

    public Transform[] spawnPoints4;
    public GameObject spritePrefab4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Showslowdownpowerup());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnslowdownpowerups(GameObject spritePrefab4)
    {
        int randomIndex = Random.Range(0, spawnPoints4.Length);

        for (int i = 0; i < spawnPoints4.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(spritePrefab4, spawnPoints4[i].position, Quaternion.identity);

            }

        }
    }
    IEnumerator Showslowdownpowerup()
    {
        yield return new WaitForSeconds(Random.Range(6, 10));
        while (player == playeralive)
        {
            Spawnslowdownpowerups(spritePrefab4);
            yield return new WaitForSeconds(Random.Range(9, 14));
        }

    }
}
