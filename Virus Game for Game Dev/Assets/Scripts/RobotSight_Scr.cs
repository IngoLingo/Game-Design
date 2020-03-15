using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSight_Scr : MonoBehaviour
{
    private bool seePlayer = false;

    private void Update()
    {
        GameObject playerObject = GetComponent<RobotStates_Scr>().playerObject;
        float dist = Vector3.Distance(playerObject.transform.position, transform.position);

        if (dist <= 5)
        {
            if (GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean)
            {
                seePlayer = true;
                GetComponent<RobotStates_Scr>().myRobotModeSt = RobotStates_Scr.RobotModeStates.Move;
            }
            else
            if (GetComponent<RobotStates_Scr>().myRobotStatusSt != RobotStates_Scr.RobotStatusStates.Clean)
            {
                seePlayer = false;
            }
        }
        else if(dist > 5)
        {
            seePlayer = false;
            StartCoroutine(StopChase());
        }
    }

    private IEnumerator StopChase()
    {
        yield return new WaitForSeconds(5f);
        if (seePlayer == false && GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean)
        {
            GetComponent<RobotStates_Scr>().myRobotModeSt = RobotStates_Scr.RobotModeStates.Idle;
        }
    }
}
