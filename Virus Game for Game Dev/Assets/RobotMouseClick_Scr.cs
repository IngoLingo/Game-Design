using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMouseClick_Scr : MonoBehaviour
{

    private void OnMouseDown()
    {
        GameObject playerObject = GetComponent<RobotStates_Scr>().playerObject;
        float dist = Vector3.Distance(playerObject.transform.position, transform.position);

        if (dist <= 1.5f)
        {
            //make player jump to robot position
            //change player state
            //change robot state
        }
        print("Distance to other: " + dist);
    }
}
