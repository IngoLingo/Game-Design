using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStates_Scr : MonoBehaviour
{    
    public enum RobotStatusStates {Clean, Infected, Off};
    //public enum RobotModeStates {Idle, Move, Attack, Stun};

    public RobotStatusStates myRobotStatusSt;

    
private void Update()
    {
        //States
        if (myRobotStatusSt == RobotStatusStates.Clean)
        {
            //GetComponent<Renderer>().material.color = new Color(1f,0.5f,0.5f);
        }
        else if (myRobotStatusSt == RobotStatusStates.Infected)
        {
            //GetComponent<Renderer>().material.color = new Color(0.5f,1f,0.5f);
        }
        else if (myRobotStatusSt == RobotStatusStates.Off)
        {
            //GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
        }
    }

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player")
        {
            myRobotStatusSt = RobotStatusStates.Infected;
        }
    }
}
