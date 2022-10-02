using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rgbody2d;
    public CircleCollider2D circlecollider2d;
    public GameObject ball;

    public float speed;
    public Text redMessage;
    public Text blueMessage;

    // Start is called before the first frame update
    void Start()
    {
        // When game is started, launch the ball to the right direction 
        rgbody2d.velocity = Vector2.right * speed + Vector2.up * Random.Range(-speed, speed);
        
    }

    void Update()
    {
        // If red message or blue message is active in the hierarchy
        if (redMessage.gameObject.activeInHierarchy == true || blueMessage.gameObject.activeInHierarchy == true)
        {
            rgbody2d.velocity = Vector2.zero; // Set vector3 to zero (stop all movements)
        }
        else
        {
            // Normalized the velocity so that the ball will never slow down
            rgbody2d.velocity = rgbody2d.velocity.normalized * speed;
        }
    }


}
