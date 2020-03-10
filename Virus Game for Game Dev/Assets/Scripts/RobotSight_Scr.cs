using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSight_Scr : MonoBehaviour
{
    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (transform.parent.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean)
        {
            if (otherObject.gameObject.tag == "Player")
            {
                transform.parent.GetComponent<RobotStates_Scr>().myRobotModeSt = RobotStates_Scr.RobotModeStates.Move;
            }
        }
    }

    private void OnTriggerExit(Collider otherObject)
	{
        if (transform.parent.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean)
        {
            if (otherObject.gameObject.tag == "Player")
            {
                transform.parent.GetComponent<RobotStates_Scr>().myRobotModeSt = RobotStates_Scr.RobotModeStates.Idle;
            }
        }
    }
}
