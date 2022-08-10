using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnlarge : MonoBehaviour
{
    bool playeralive = true;
    public GameObject player;

    public Transform[] spawnPoints3;
    public GameObject spritePrefab3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Showenlargepowerup());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnenlargepowerups(GameObject spritePrefab3)
    {
        int randomIndex = Random.Range(0, spawnPoints3.Length);

        for (int i = 0; i < spawnPoints3.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(spritePrefab3, spawnPoints3[i].position, Quaternion.identity);

            }

        }
    }
    IEnumerator Showenlargepowerup()
    {
        yield return new WaitForSeconds(Random.Range(5, 8));
        while (player == playeralive)
        {
            Spawnenlargepowerups(spritePrefab3);
            yield return new WaitForSeconds(Random.Range(8, 16));
        }

    }
}
