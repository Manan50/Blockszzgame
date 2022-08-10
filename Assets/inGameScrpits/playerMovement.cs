using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private float speed = 13f;
    private Rigidbody2D rb;
    public float mapWidth = 5f;
    public AudioSource gameover;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameover = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = CrossPlatformInputManager.GetAxisRaw("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
    }
    
        void OnCollisionEnter2D()
    {
        gameover.Play();
        FindObjectOfType<gamemanger>().EndGame();
        
    }
}
