using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapFloors_Scr : MonoBehaviour
{
    public GameObject currentFloor;
    public GameObject newFloor;

    private void OnTriggerEnter(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "Robot" &&
                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Infected)
        {
            otherObject.gameObject.transform.Translate(-Vector3.forward * 20 * Time.deltaTime);
            otherObject.gameObject.transform.SetParent(newFloor.transform);
            //otherObject.GetComponent<RobotMovement_Scr>().enabled = false;

            newFloor.SetActive(true);
            currentFloor.SetActive(false);
        }
    }
}
