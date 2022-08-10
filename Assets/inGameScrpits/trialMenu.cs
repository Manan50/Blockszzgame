using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trialMenu : MonoBehaviour
{
    public void Start()
    {

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Admob.instance.RequestBanner();

        }
         if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Admob.instance.HideBanner();

        }
           if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Admob.instance.RequestBanner();

        }

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
