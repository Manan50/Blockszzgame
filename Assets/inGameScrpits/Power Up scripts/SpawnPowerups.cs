using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPowerups : MonoBehaviour
{

    bool playeralive = true;
    public GameObject player;
    
    
    public Transform[] spawnPoints;
    public GameObject spritePrefab;
   
    
    

    

   

    

    // Start is called before the first frame update
    void Awake()
    {
        
    }
    private void Start()
    {
        
            StartCoroutine(Showpowerup());
        
        
        
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnpowerups(GameObject spritePrefab)
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(spritePrefab, spawnPoints[i].position, Quaternion.identity);

            }

        }
    }

    IEnumerator Showpowerup()
    {
        yield return new WaitForSeconds(Random.Range(3, 4));
        while (player == playeralive)
        {
            Spawnpowerups(spritePrefab);
            yield return new WaitForSeconds(Random.Range(5, 9));
        }
        
    }
  
   
    
    
}
