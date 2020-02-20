using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseForMazeGame : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject mazeGameUI;
    public GameObject whatIsPaused;
    public GameObject doorToUnlock;

    private void OnTriggerStay2D(Collider2D otherObject)
	{
        if (otherObject.gameObject.tag == "Player")
        {
            Resume();
        }
    }


    void Resume()
    {
        mazeGameUI.SetActive(false);
        whatIsPaused.SetActive(true);
        doorToUnlock.SetActive(false);
        //Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        mazeGameUI.SetActive(true);
        whatIsPaused.SetActive(false);
        //Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
