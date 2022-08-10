using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorein : MonoBehaviour
{
    public static Scorein instance;
    private static Text scoreText;
    private static Text hscoreText;
    public int scr, highscore;

    void Start()
    {
        

        PlayerPrefs.SetInt("Score", Scorein.instance.scr);
        highscore = PlayerPrefs.GetInt("HScore");
        hscoreText.text = PlayerPrefs.GetInt("HScore").ToString();
    }
    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        hscoreText = GameObject.Find("HSText").GetComponent<Text>();
        MakeInstance();
    }

    // Update is called once per frame
    void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
    public void IncrementScore()
    {
        
        scr++;
        UpdateHS();
        scoreText.text = ""+ scr / 4;
       


    }
    public int GetScore()
    {
       
        return this.scr / 4;
    }
    public void UpdateHS()
    {
        if (scr/4 > highscore)
        {
            highscore = scr/4;
            hscoreText.text = highscore.ToString();
            PlayerPrefs.SetInt("HScore", highscore);
        }
    }
    public int HighScore()
    {


        return this.highscore/4;


    }
    private void Update()
    {
        
    }
}
