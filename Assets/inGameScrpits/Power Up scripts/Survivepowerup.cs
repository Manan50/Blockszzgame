using EasyUI.Toast;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Survivepowerup : MonoBehaviour
{
    bool resetPowerUp;
    public GameObject pickupeffect;
    private float duration = 4f;

    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            StartCoroutine(PickUp(collision));
        }
    }
    IEnumerator PickUp(Collider2D player)
    {
        Instantiate(pickupeffect, transform.position, transform.rotation);
        Toast.Show("Phase Through", 1, ToastColor.Blue);
        player.GetComponent<BoxCollider2D>().isTrigger = true;
        player.GetComponent<Rigidbody2D>().gravityScale = 0;
        player.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
        

        //Takes a timeStamp
        float timeStamp = Time.time;

        //While the current time is less than the timeStamp + the duration of the power up
        while (Time.time < timeStamp + duration)
        {
            //If the flag to reset the powerup is active
            if (resetPowerUp)
            {
                //Toggle it off
                resetPowerUp = false;
                //reset the powerup so that it ends in (current time + 5 seconds);
                timeStamp = Time.time;
            }
            yield return null;
        }
       
    
        //Otherwise, it means that a different powerup routine is already running
        //We're just going to let that other routine know that it should reset the timer
        

GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(duration);



        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.GetComponent<Rigidbody2D>().gravityScale = 1;
        player.GetComponent<SpriteRenderer>().color = new Color(255, 0, 255, 1f);


        
        
            resetPowerUp = true;
        

        Destroy(gameObject);
    }
}
