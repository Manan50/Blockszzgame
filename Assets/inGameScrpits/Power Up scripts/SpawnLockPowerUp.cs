using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLockPowerUp : MonoBehaviour
{
    bool playeralive = true;
    public GameObject player;

    public Transform[] spawnPoints1;
    public GameObject spritePrefab1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Showlockpowerup());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnlockpowerups(GameObject spritePrefab1)
    {
        int randomIndex = Random.Range(0, spawnPoints1.Length);

        for (int i = 0; i < spawnPoints1.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(spritePrefab1, spawnPoints1[i].position, Quaternion.identity);

            }

        }
    }
    IEnumerator Showlockpowerup()
    {
        yield return new WaitForSeconds(Random.Range(5, 6));
        while (player == playeralive)
        {
            Spawnlockpowerups(spritePrefab1);
            yield return new WaitForSeconds(Random.Range(6, 12));
        }

    }
}
