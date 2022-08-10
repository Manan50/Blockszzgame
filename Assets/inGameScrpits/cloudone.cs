using CloudOnce;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudone : MonoBehaviour
{
    public static cloudone instance;
    
    // Start is called before the first frame update
    private void Awake()
    {
        
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void Submit(int score)
    {
        Leaderboards.HighScore.SubmitScore(score);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
