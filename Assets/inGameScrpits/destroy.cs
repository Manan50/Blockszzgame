using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public static destroy instance;
    public GameObject blockPrefab;
    public float gravity = 20f;



    private void Awake()
    {
        MakeInstance();
    }
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravity;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -3f && Scorein.instance != null)
        {
            GameObject.FindGameObjectsWithTag("Blocks");  //returns GameObject[]
            Scorein.instance.IncrementScore();
            PlayerPrefs.SetInt("Score", Scorein.instance.GetScore());
            PlayerPrefs.SetInt("HScore", Scorein.instance.highscore);
        }
        
        if (transform.position.y < -3f)
        {
            Destroy(gameObject);
        }
    }
    void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
}
