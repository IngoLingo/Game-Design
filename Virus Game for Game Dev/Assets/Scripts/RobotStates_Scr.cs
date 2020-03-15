using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotStates_Scr : MonoBehaviour
{    
    public enum RobotStatusStates {Clean, Infected, Off};
    public enum RobotModeStates {Idle, Move, Interact, Stun};
    public bool canAttack = true;

    public RobotStatusStates myRobotStatusSt;
    public RobotModeStates myRobotModeSt;
    public GameObject objectGeo;
    public GameObject playerObject;



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

            if (playerObject.GetComponentInChildren<PlayerDeathCheck_Scr>().backupList.Contains(this.gameObject))
            {
                playerObject.GetComponentInChildren<PlayerDeathCheck_Scr>().backupList.Remove(this.gameObject);
            }
        }
    }
}
