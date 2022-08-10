using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreend : MonoBehaviour
{
    
    public Text finalScr;
    public Text initialScr;

    // Start is called before the first frame update
    void Update()
    {
        initialScr.text = PlayerPrefs.GetInt("Score").ToString();
        finalScr.text = PlayerPrefs.GetInt("HScore").ToString();


    }
    public void OnEnable()
    {
        cloudone.instance.Submit(PlayerPrefs.GetInt("HScore"));
    }
}

