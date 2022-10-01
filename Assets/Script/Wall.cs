using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public GameManager gameManager;

    public bool isAi;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // If collided with object tagged with ball
        if (collision.transform.CompareTag("ball"))
        {
            if (isAi) // If wall is AI goal post
            {
                gameManager.AddAi(); // Add point to AI score
            }
            else // If not
            {
                gameManager.AddPlayer(); // Add point to player score
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
