using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseForMazeGame : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject mazeGameUI;
    public GameObject whatIsPaused;
    public GameObject doorToUnlock;

    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player")
        {
            //Debug.Log("Hit");
            Resume();
        }
    }


    void Resume()
    {
        mazeGameUI.SetActive(false);
        whatIsPaused.SetActive(true);
        doorToUnlock.GetComponent<DoorStates_Scr>().myDoorStatusSt = DoorStates_Scr.DoorStatusStates.Infected;
        doorToUnlock.GetComponent<DoorStates_Scr>().DoorOpen = true;
        GameIsPaused = false;
    }

    void Pause()
    {
        mazeGameUI.SetActive(true);
        whatIsPaused.SetActive(false);
        GameIsPaused = true;
    }
}
