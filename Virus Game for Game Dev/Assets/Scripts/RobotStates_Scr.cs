using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStates_Scr : MonoBehaviour
{    
    public enum RobotStatusStates {Clean, Infected, Off};
    public enum RobotModeStates {Idle, Move, Interact, Stun};

    public RobotStatusStates myRobotStatusSt;
    public RobotModeStates myRobotModeSt;
    public GameObject objectGeo;

    
private void Update()
    {
        //States
        if (myRobotStatusSt == RobotStatusStates.Clean)
        {
            objectGeo.GetComponent<Renderer>().material.color = new Color(1f,0.5f,0.5f);
        }
        else if (myRobotStatusSt == RobotStatusStates.Infected)
        {
            objectGeo.GetComponent<Renderer>().material.color = new Color(0.5f,1f,0.5f);
        }
        else if (myRobotStatusSt == RobotStatusStates.Off)
        {
            objectGeo.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
        }
    }

    //Check Triggers
    /*private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player")
        {
            myRobotStatusSt = RobotStatusStates.Infected;
            myRobotModeSt = RobotModeStates.Move;
        }
    }

    private void OnTriggerExit(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player")
        {
            myRobotModeSt = RobotModeStates.Idle;
        }
    }*/
}
