using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScore = 0;
    public int AiScore = 0;
    public float movementSpd = 20f;

    public Text AI;
    public Text Player;
    public Text redMessage;
    public Text blueMessage;
    public Button PauseButton;
    public Button ResumeButton;

    public GameObject Ball;
    public GameObject leftPaddle;
    public GameObject rightPaddle;


    private bool GameStatus = false;

    // Add point to AI score if AI scored
    public void AddAi()
    {
        // If ai score is less than 5 and ai score is less than 5
        if (AiScore < 5 && PlayerScore < 5)
        {
            AiScore += 1; // Increment Ai score
            AI.text = AiScore.ToString(); // Convert the int of ai score to string and assign it as the text message
        }
        // If ai score is 5 and player score is less than 5
        else if (AiScore == 5 && PlayerScore < 5)
        {
            return; // Return, stop incrementing the point
        }

    }

    // Add point to Player score if player scored
    public void AddPlayer()
    {
        // If player score is less than 5 and ai score is less than 5
        if (PlayerScore < 5 && AiScore < 5)
        {
            PlayerScore += 1; // Increment player score
            Player.text = PlayerScore.ToString(); // Convert the int of player score to string and assign it as the text message          

        }
        // If player score is 5 and ai score is less than 5
        else if (PlayerScore == 5 && AiScore < 5)
        {
            return; // Return, stop incrementing the point
        }
    }

    // Restart game
    public void Restart()
    {
        // Load the scene when restart button is press
        SceneManager.LoadScene("Game");
        
    }

    // Pause game
    public void Pause()
    {
        Time.timeScale = 0; // Pause the game
        ResumeButton.gameObject.SetActive(true); // Show the resume button so that player can resume the game
    }
    
    // Resume game
    public void Resume()
    {
        Time.timeScale = 1; // Resume the game
        ResumeButton.gameObject.SetActive(false); // Hide the resume button as the player has resumed the game
    }

    // Congratulate message to whoever that won the game
    public void Congratulate()
    {
        // If ai score is 5 and player score is less than 5
        if (AiScore == 5 && PlayerScore < 5)
        {
            redMessage.gameObject.SetActive(true); // Show the congratulation message for the ai
            GameStatus = true; // Set game end to true

        }
        // If player score is 5 and ai score is less than 5
        else if (PlayerScore == 5 && AiScore < 5)
        {
            blueMessage.gameObject.SetActive(true); // Show the congratulation message for the player
            GameStatus = true; // Set game end to true

        }
    }

    // Game end bool value will be the same as return value (if game status is false, game end will return false)
    public bool GameEnd()
    {
        return GameStatus; // Return game status bool value
    }

    // Start is called before the first frame update
    void Start()
    {

        // Hide the messages and resume button when the game is started
        blueMessage.gameObject.SetActive(false);
        redMessage.gameObject.SetActive(false);
        ResumeButton.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        // Invoke the congratulate method in update
        Congratulate();

    }
}
