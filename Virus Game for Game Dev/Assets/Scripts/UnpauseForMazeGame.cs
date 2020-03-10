using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseForMazeGame : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject mazeGameUI;
    public GameObject whatIsPaused;
    //public GameObject doorToUnlock;
    public GameObject associatedKey;

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
        associatedKey.GetComponent<KeyStates_Scr>().myKeyStatusSt = KeyStates_Scr.KeyStatusStates.Infected;
        associatedKey.GetComponent<KeyStates_Scr>().myKeyModeSt = KeyStates_Scr.KeyModeState.OpenLock;
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
