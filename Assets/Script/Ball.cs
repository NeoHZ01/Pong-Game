using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rgbody2d;
    public CircleCollider2D circlecollider2d;
    public GameObject ball;
    public GameManager gameManager;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // When game is started, launch the ball to the right direction 
        rgbody2d.velocity = Vector2.right * speed + Vector2.up * Random.Range(-speed, speed);
        
    }

    void Update()
    {
        // If game end is true
        if (gameManager.GameEnd() == true)
        {
            rgbody2d.velocity = Vector2.zero; // Set vector2 to zero (stop all movements)
        }
        else
        {
            // Normalized the velocity so that the ball will never slow down
            rgbody2d.velocity = rgbody2d.velocity.normalized * speed;
        }
    }


}
