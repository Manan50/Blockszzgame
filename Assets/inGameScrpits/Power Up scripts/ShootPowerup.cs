using EasyUI.Toast;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPowerup : MonoBehaviour
{
    bool resetPowerUp;
    private float duration = 4f;

    public GameObject pickupeffect;
    public GameObject pickupeffect1;
    

    private GameObject firepoint;
    private GameObject firepoint1;
    

    public GameObject BulletPrefab2;
    public GameObject BulletPrefab3;

    private void Start()
    {
        firepoint = GameObject.FindWithTag("point"); 
        firepoint1 = GameObject.FindWithTag("point1"); 
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
        Instantiate(pickupeffect1, firepoint.transform.position, firepoint.transform.rotation);
        Instantiate(pickupeffect1, firepoint1.transform.position, firepoint1.transform.rotation);
        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 255, 1f);
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        Toast.Show("Shoot", 1, ToastColor.Blue);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();
        yield return new WaitForSeconds(0.2f);
        Shoot();

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






        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.GetComponent<SpriteRenderer>().color = new Color(255, 0, 255, 1f);
        Instantiate(pickupeffect1, firepoint.transform.position, firepoint.transform.rotation);
        Instantiate(pickupeffect1, firepoint1.transform.position, firepoint1.transform.rotation);

        resetPowerUp = true;

        Destroy(this.gameObject);
    }

    void Shoot()
    {

        GameObject bullets = Instantiate(BulletPrefab2, firepoint.transform.position, firepoint.transform.rotation);
        Rigidbody2D rb = bullets.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.transform.up * 20f, ForceMode2D.Impulse);
        GameObject bullets1 = Instantiate(BulletPrefab3, firepoint1.transform.position, firepoint1.transform.rotation);
        Rigidbody2D rb1 = bullets1.GetComponent<Rigidbody2D>();
        rb1.AddForce(firepoint1.transform.up * 20f, ForceMode2D.Impulse);
    }
}
