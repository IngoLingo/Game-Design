using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStates_Scr : MonoBehaviour
{
    public enum DoorStatusStates { Open, Close };
    public DoorStatusStates myDoorStatusSt;

    public GameObject childOpenObj;
    public GameObject childCloseObj;

    void Start()
    {
        if (myDoorStatusSt == DoorStatusStates.Open)
        {
            OpenDoor();
        }

        if (myDoorStatusSt == DoorStatusStates.Close)
        {
            CloseDoor();
        }
    }

    //May need to replace with something that dosent run all the time
    void Update()
    {
        if (myDoorStatusSt == DoorStatusStates.Open)
        {
            OpenDoor();
        }

        if (myDoorStatusSt == DoorStatusStates.Close)
        {
            CloseDoor();
        }
    }

    private void OnTriggerStay(Collider otherObject)
    {
        if ((myDoorStatusSt == DoorStatusStates.Close) && (
            otherObject.gameObject.tag == "Player" ||
            otherObject.gameObject.tag == "Robot" /*||
            otherObject.gameObject.tag == "Human"*/))
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        childOpenObj.SetActive(true);
        childCloseObj.SetActive(false);
    }

    void CloseDoor()
    {
        childOpenObj.SetActive(false);
        childCloseObj.SetActive(true);
    }
}
