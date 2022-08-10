using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Pause1 : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Button PauseUI;
    public Sprite Play;
    public Sprite Pause2;
    public AudioSource audioSource;



    public void Pause()
    {
        GameIsPaused = !GameIsPaused;
        if (!GameIsPaused)
        {
            PauseUI.image.sprite = Pause2;
            Time.timeScale = 1;
            audioSource.Play();


        }
        else if(GameIsPaused)
        {
            PauseUI.image.sprite = Play;
            Time.timeScale = 0;
            
            audioSource.Pause();
        }
    }
}
    