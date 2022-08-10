using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlinks : MonoBehaviour
{
    // Start is called before the first frame update
    public void Mail()
    {
        Application.OpenURL("https://manan50.github.io/cv/contacts.html");
    }
    public void Insta()
    {
        Application.OpenURL("https://www.instagram.com/manan_parikh_/");
    }
    public void Youtube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCXEI2NkKy0eOEUuTh5V3RaQ");
    }
}
