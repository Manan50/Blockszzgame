﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu2 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
