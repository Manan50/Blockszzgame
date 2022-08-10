using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Smoothtouch : MonoBehaviour
{
    private float minX = -5f;
    
    private float maxX = 5f;
    

    private float playerSpeed = 13f;

    [SerializeField] private Camera _mainCamera;

    void Awake()
    {
        if (!_mainCamera) _mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            var touchPosition = touch.position;

            var currentPosition = transform.position;
            
            var speed = playerSpeed * Time.deltaTime / Time.timeScale;

            // get this objects position in screen (pixel) space
            var screenPosition = _mainCamera.WorldToScreenPoint(transform.position);

            if (touchPosition.x < screenPosition.x)
            {
                currentPosition.x -= speed;
            }
            else if (touchPosition.x > screenPosition.x)
            {
                currentPosition.x += speed;
            }

            currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
            if (Pause1.GameIsPaused == false)
            {
                transform.position = currentPosition;
            }
            /*if (touchPosition.y < screenPosition.y)
            {
                currentPosition.y -= speed;
            }
            else if (touchPosition.y > screenPosition.y)
            {
                currentPosition.y += speed;
            }

            currentPosition.y = Mathf.Clamp(currentPosition.y, minX, maxX);

            transform.position = currentPosition;*/

        }

        

    }
    void OnCollisionEnter2D()
    {

        FindObjectOfType<gamemanger>().EndGame();

    }
}
