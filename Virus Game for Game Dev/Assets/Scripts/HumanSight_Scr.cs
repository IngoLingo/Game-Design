using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSight_Scr : MonoBehaviour
{
    private void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "Player")
        {
            if (!transform.parent.GetComponent<HumanMovement_Scr>().targetList.Contains(otherObject.gameObject))
            {
                transform.parent.GetComponent<HumanMovement_Scr>().targetList.Add(otherObject.gameObject);
            }
        }

        if (otherObject.GetComponent<RobotStates_Scr>() != null)
        {
                if (otherObject.gameObject.tag == "Robot" && otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt != RobotStates_Scr.RobotStatusStates.Clean)
            {
                if (!transform.parent.GetComponent<HumanMovement_Scr>().targetList.Contains(otherObject.gameObject))
                {
                    transform.parent.GetComponent<HumanMovement_Scr>().targetList.Add(otherObject.gameObject);
                }
            }
            else if (otherObject.gameObject.tag == "Robot" && otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean)
            {
                if (transform.parent.GetComponent<HumanMovement_Scr>().targetList.Contains(otherObject.gameObject))
                {
                    transform.parent.GetComponent<HumanMovement_Scr>().targetList.Remove(otherObject.gameObject);
                }
            }
        }
    }
}
