using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewScore : MonoBehaviour
{
    public static NewScore instance;

    public int score, highscore;
    private static Text scoreText;
    private static Text hscoreText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", NewScore.instance.score);
        highscore = PlayerPrefs.GetInt("HScore");
        hscoreText.text = PlayerPrefs.GetInt("HScore").ToString();

    }
    public void Awake()
    {
        MakeInstance();
        
        
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        hscoreText = GameObject.Find("HSText").GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            
            instance = this;
        }
        
    }
    public void AddScore()
    {
        score++;
        UpdateHS();
        scoreText.text = score.ToString();
        
    }
    public int GetScore()
    {

        return this.score;


    }
    public void UpdateHS()
    {
        if (score > highscore)
        {
            highscore = score;
            hscoreText.text = highscore.ToString();
            PlayerPrefs.SetInt("HScore", highscore);
        }
    }
    public int HighScore()
    {
        
        
        return this.highscore;


    }
}
