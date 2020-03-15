using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanInteractCollision_Scr : MonoBehaviour
{
    public float attackDelay = 60f;
    public float attackDelayReset = 60f;
    public GameObject mainParentObject;

    void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.GetComponent<RobotStates_Scr>() != null)
        {
            if (otherObject.gameObject.tag == "Robot" && otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt != RobotStates_Scr.RobotStatusStates.Clean)
            {
                if (attackDelay <= 0)
                {
                    attackDelay = attackDelayReset;

                    if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Infected)
                    {
                        otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Off;
                        //mainParentObject.GetComponent<HumanStates_Scr>().myHumanModeSt = HumanStates_Scr.HumanModeStates.Idle;
                    }
                    else if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Off)
                    {
                        otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Clean;
                        //mainParentObject.GetComponent<HumanStates_Scr>().myHumanModeSt = HumanStates_Scr.HumanModeStates.Idle;
                    }
                }
                else
                {
                    attackDelay -= 1;
                }
            }


            if (otherObject.gameObject.tag == "Robot" && otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt != RobotStates_Scr.RobotStatusStates.Clean)
            {
                //mainParentObject.GetComponent<HumanStates_Scr>().myHumanModeSt = HumanStates_Scr.HumanModeStates.Move;
            }
        }
    }
}
