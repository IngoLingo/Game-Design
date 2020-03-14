using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStates_Scr : MonoBehaviour
{
    public enum DoorStatusStates { Clean, Infected, Off };
    public bool DoorOpen = false;

    public DoorStatusStates myDoorStatusSt;

    public GameObject playerObject;
    public GameObject geoToColor;

    public GameObject childOpenObj;
    public GameObject childCloseObj;

    void Start()
    {
        if (DoorOpen == true)
        {
            OpenDoor();
        }

        if (DoorOpen == false)
        {
            CloseDoor();
        }
    }

    //May need to replace with something that dosent run all the time
    void Update()
    {
        //Open/Close
        if (DoorOpen == true)
        {
            OpenDoor();
        }
        if (DoorOpen == false)
        {
            CloseDoor();
        }

        //Colors
        if (myDoorStatusSt == DoorStatusStates.Clean)
        {
            geoToColor.GetComponent<Renderer>().material.color = new Color(1f, 0.5f, 0.5f);
        }
        else if (myDoorStatusSt == DoorStatusStates.Infected)
        {
            geoToColor.GetComponent<Renderer>().material.color = new Color(0.5f, 1f, 0.5f);
        }
        else if (myDoorStatusSt == DoorStatusStates.Off)
        {
            geoToColor.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
        }
    }

    private void OnTriggerStay(Collider otherObject)
    {
        if ((DoorOpen == false) && (
            otherObject.gameObject.tag == "Player" ||
            otherObject.gameObject.tag == "Robot" ||
            otherObject.gameObject.tag == "Human"))
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
