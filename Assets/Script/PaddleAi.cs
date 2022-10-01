using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PaddleAi : MonoBehaviour
{
    public Rigidbody2D rgbody2d;
    public BoxCollider2D boxcollider2d;
    public float movementSpd = 20f;
    public GameObject ceiling;
    public GameObject floor;
    public Text redMessage;
    public Text blueMessage;

    private GameObject player;
    private bool down = true;

    void Start()
    {
        // When game is started, find the game object of player
        player = GameObject.FindWithTag("player");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // If the paddle collide with another game object tagged with ceiling
        if (other.gameObject.tag == "ceiling") 
        {
            // Bool variable will be true
            down = true;
        }
        // If the paddle collide with another game object tagged with floor
        else if (other.gameObject.tag == "floor")
        {
            // Bool variable will be false
            down = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // If player is true
        if (player)
        {
            // If down is true and both red message and blue message is not active
            if (down == true && redMessage.gameObject.activeInHierarchy == false && blueMessage.gameObject.activeInHierarchy == false)
            {
                // Move the paddle downward
                rgbody2d.MovePosition(transform.position + new Vector3(0, -(Time.deltaTime * movementSpd), 0));
            }
            // If down is false and both red message and blue message is not active
            else if (down == false && redMessage.gameObject.activeInHierarchy == false && blueMessage.gameObject.activeInHierarchy == false)
            {
                // Move the paddle upward
                rgbody2d.MovePosition(transform.position + new Vector3(0, Time.deltaTime * movementSpd, 0));
            }
        }
    }
}
