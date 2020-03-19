using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotInteractCollision_Scr : MonoBehaviour
{
    public float attackDelay = 60f;
    public float attackDelayReset = 60f;
    public GameObject mainParentObject;

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
    {
        if (mainParentObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean)
        {
            if (otherObject.GetComponent<RobotStates_Scr>() != null)
            {
                if (((otherObject.gameObject.tag == "Robot" &&
                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Infected) ||
                otherObject.gameObject.tag == "InfectableObjectCollision") &&
                mainParentObject.GetComponent<RobotStates_Scr>().canAttack == true)
                {
                    if (attackDelay <= 0)
                    {
                        if (otherObject.gameObject.tag == "Robot")
                        {
                            otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Off;
                        }
                        else if (otherObject.gameObject.tag == "InfectableObjectCollision")
                        {
                            otherObject.transform.parent.GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt = InfectableCollisionStates_Scr.ObjectStatusStates.Firewall;
                        }
                        attackDelay = attackDelayReset;
                    }
                    else
                    {
                        attackDelay -= 1;
                    }
                }
            }
        }
    }

    private void OnTriggerExit(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "Robot" || otherObject.gameObject.tag == "InfectableObjectCollision")
        {
            attackDelay = attackDelayReset;
        }
     
    }
}
