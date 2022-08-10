using EasyUI.Toast;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LockPowerUp : MonoBehaviour
{
    
    public GameObject pickupeffect;
    private float duration = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        Toast.Show("Player Locked", 1, ToastColor.Blue);
        var x = player.transform.position;
        Smoothtouch movement = player.GetComponent<Smoothtouch>();
        movement.enabled = false;
       
            
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.GetComponent<SpriteRenderer>().color = new Color(255, 255, 0, 1f);


        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(duration);

        player.GetComponent<BoxCollider2D>().isTrigger = false;
        
        movement.enabled = true;
        player.GetComponent<SpriteRenderer>().color = new Color(255, 0, 255, 1f);

        

        Destroy(gameObject);
    }
}
