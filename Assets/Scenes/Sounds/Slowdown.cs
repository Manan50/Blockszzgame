using EasyUI.Toast;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowdown : MonoBehaviour
{
   
    private float slowDownFactor = 0.2f;
    public float slowlength = 2f;
    public AudioSource audio1;
    public AudioSource audio2;
    
    public GameObject pickupeffect;
    private float duration = 2f;

    public AudioClip Clip;
    private void Start()
    {
        
    }
    public void SlowMotion()
    {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        
        
    }
    public void NormalMotion()
    {

        Time.timeScale = 1f;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            StartCoroutine(PickUp(collision));
            audio1.Play();
            audio2.PlayOneShot(Clip);
            
        }
    }
    IEnumerator PickUp(Collider2D player)
    {
        Instantiate(pickupeffect, transform.position, transform.rotation);

        yield return new WaitForSeconds(0.2f);
        Toast.Show("Time Slow", 1, ToastColor.Blue);
        SlowMotion();

        

        //While the current time is less than the timeStamp + the duration of the power up
      

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(1.5f);
        NormalMotion();
        
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        
        
        player.GetComponent<SpriteRenderer>().color = new Color(255, 0, 255, 1f);
        

        Destroy(gameObject);    
    }
}
