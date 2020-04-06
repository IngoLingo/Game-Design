using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMouseClick_Scr : MonoBehaviour
{

    private void OnMouseDown()
    {
        GameObject playerObject = GetComponent<RobotStates_Scr>().playerObject;
        float dist = Vector3.Distance(playerObject.transform.position, transform.position);

        switch (GetComponent<RobotStates_Scr>().myRobotStatusSt)
        {
            case RobotStates_Scr.RobotStatusStates.Off:
                if (dist <= 1.5f && playerObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot)
                {
                    GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Clean;
                }
                break;

            case RobotStates_Scr.RobotStatusStates.Clean:
                if (dist <= 1.5f)
                {
                    transform.rotation = Quaternion.identity;
                    playerObject.gameObject.transform.position = transform.position;
                    playerObject.gameObject.transform.SetParent(gameObject.transform);
                    playerObject.gameObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                }
                break;

            case RobotStates_Scr.RobotStatusStates.Infected:
                transform.rotation = Quaternion.identity;
                playerObject.gameObject.transform.position = transform.position;
                playerObject.gameObject.transform.SetParent(gameObject.transform);
                playerObject.gameObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                break;
        }

    }
}
