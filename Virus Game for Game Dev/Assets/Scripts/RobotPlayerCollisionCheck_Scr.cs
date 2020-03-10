using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPlayerCollisionCheck_Scr : MonoBehaviour
{
    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player")
        {
            transform.parent.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Infected;
            transform.parent.GetComponent<RobotStates_Scr>().myRobotModeSt = RobotStates_Scr.RobotModeStates.Move;
            transform.parent.transform.rotation = Quaternion.identity;
            otherObject.transform.rotation = Quaternion.identity;
        }
    }

    private void OnTriggerExit(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player")
        {
            transform.parent.GetComponent<RobotStates_Scr>().myRobotModeSt = RobotStates_Scr.RobotModeStates.Idle;
        }
    }
}
