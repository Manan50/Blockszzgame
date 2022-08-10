using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    public AudioSource source;
    
    public GameObject pickupeffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Blocks")
        {
            Instantiate(pickupeffect, transform.position, transform.rotation);
            Instantiate(source, transform.position, transform.rotation);
            Scorein.instance.IncrementScore();
            PlayerPrefs.SetInt("Score", Scorein.instance.GetScore());
            PlayerPrefs.SetInt("HScore", Scorein.instance.highscore);
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }
        
        

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > 5f)
        {
            Destroy(this.gameObject);
        }

    }
}
