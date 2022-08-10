using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Toggle))]
public class MuteToggle : MonoBehaviour
{

    public Toggle mutetoggle;
    // Start is called before the first frame update
    void Start()
    {
        mutetoggle = GetComponent<Toggle>();
        if (AudioListener.volume == 0)
        {
            mutetoggle.isOn = false;
        }
    }
    public void AudioValueChange(bool audioIn)
    {
        if (audioIn)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
