using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public Rigidbody2D rgbody2d;
    public BoxCollider2D boxcollider2d;

    public float movementSpd = 20f;
    public Text redMessage;
    public Text blueMessage;

    // Update is called once per frame
    void Update()
    {
        // If red message is active in the hierarchy
        if (redMessage.gameObject.activeInHierarchy == true)
        {
            rgbody2d.velocity = Vector3.zero; // Set vector3 to zero (stop all movements)
        }
        // If blue message is active in the hierarchy
        else if (blueMessage.gameObject.activeInHierarchy == true)
        {
            rgbody2d.velocity = Vector3.zero; // Set vector3 to zero (stop all movements)
        }
        else
        {
            // Get the vertical axis of input and assigned it to vertical input variable
            float verticalinput = Input.GetAxis("Vertical");

            // Move the paddle up or down using vertical input controls
            rgbody2d.MovePosition(transform.position + new Vector3(0, verticalinput * movementSpd * Time.deltaTime, 0));
        }
    }
}
