using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMouseClick_Scr : MonoBehaviour
{
    public float inectedRequired;
    public Create_FloatVariable infectedCount;
    
    public GameObject mazeGameUI;
    public GameObject whatIsPaused;

    void Start()
    {
        Resume();
        infectedCount.value = 0;
    }

    private void OnMouseDown()
    {
        GameObject playerObject = GetComponent<DoorStates_Scr>().playerObject;
        float dist = Vector3.Distance(playerObject.transform.position, transform.position);

        switch (GetComponent<DoorStates_Scr>().myDoorStatusSt)
        {
            case DoorStates_Scr.DoorStatusStates.Off:
                if (dist <= 1.5f && playerObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot)
                {
                    GetComponent<DoorStates_Scr>().myDoorStatusSt = DoorStates_Scr.DoorStatusStates.Clean;
                }
                break;

            case DoorStates_Scr.DoorStatusStates.Clean:
                if (dist <= 1.5f)
                {
                    Pause();
                    //GetComponent<DoorStates_Scr>().myDoorStatusSt = DoorStates_Scr.DoorStatusStates.Infected;
                }
                break;

            case DoorStates_Scr.DoorStatusStates.Infected:
                GetComponent<DoorStates_Scr>().DoorOpen = !GetComponent<DoorStates_Scr>().DoorOpen;
                break;
        }
    }


    void Resume()
    {
        mazeGameUI.SetActive(false);
        whatIsPaused.SetActive(true);
    }

    void Pause()
    {
        mazeGameUI.SetActive(true);
        whatIsPaused.SetActive(false);
    }
}
