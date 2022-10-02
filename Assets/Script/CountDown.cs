using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public GameObject countDown;

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine named "string"
        StartCoroutine("StartDelay");
    }

    // Coroutine method
    IEnumerator StartDelay()
    {
        // Suspend the game when coroutine method is called
        Time.timeScale = 0; 

        // The amount of time to pause the game (realtimesincestartup refers to when the game has started, +3f (3 seconds) refers to how long to add on top of the base time)
        float pauseTime = Time.realtimeSinceStartup + 3f;

        // While loop, so long as realtimesincestartup hasn't exceed the pause time, keep looping
        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0; // Return 0 for each loop
        }
        countDown.gameObject.SetActive(false); // Hide the countDown game object in the screen
        Time.timeScale = 1; // Resume the game when the countdown has stopped

    }
}
