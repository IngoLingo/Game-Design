using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPlayerCollisionCheck_Scr : MonoBehaviour
{
    public GameObject mainParentObject;

    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player" &&
            otherObject.GetComponent<PlayerStates_Scr>().myPlayerStatusSt != PlayerStates_Scr.PlayerStatusStates.Dead &&
            mainParentObject.GetComponent<RobotStates_Scr>().myRobotStatusSt != RobotStates_Scr.RobotStatusStates.Off)
        {
            transform.parent.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Infected;
            transform.parent.GetComponent<RobotStates_Scr>().myRobotModeSt = RobotStates_Scr.RobotModeStates.Move;
            transform.parent.transform.rotation = Quaternion.identity;
            otherObject.transform.rotation = Quaternion.identity;
        }
        if (otherObject.gameObject.tag == "Player" && mainParentObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Off)
        {
            otherObject.GetComponent<PlayerStates_Scr>().myPlayerStatusSt = PlayerStates_Scr.PlayerStatusStates.Dead;
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
