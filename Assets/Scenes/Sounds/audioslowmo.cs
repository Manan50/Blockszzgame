using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioslowmo : MonoBehaviour
{
    public AudioSource audioslow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
           
        audioslow.pitch = Time.timeScale;
    }
}
