using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletPowerUp : MonoBehaviour
{
    bool playeralive = true;
    public GameObject player;

    public Transform[] spawnPoints2;
    public GameObject spritePrefab2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Showfirepowerup());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnfirepowerups(GameObject spritePrefab2)
    {
        int randomIndex = Random.Range(0, spawnPoints2.Length);

        for (int i = 0; i < spawnPoints2.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(spritePrefab2, spawnPoints2[i].position, Quaternion.identity);

            }

        }
    }
    IEnumerator Showfirepowerup()
    {
        yield return new WaitForSeconds(Random.Range(7, 8));
        while (player == playeralive)
        {
            Spawnfirepowerups(spritePrefab2);
            yield return new WaitForSeconds(Random.Range(7, 14));
        }

    }
}
