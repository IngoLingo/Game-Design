using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathCheck_Scr : MonoBehaviour
{
    public List<GameObject> backupList = new List<GameObject>();
    public GameObject mainParentObject;

    public GameObject gameOverUI;
    public GameObject whatIsPaused;

    // Start is called before the first frame update
    void Update()
    {
        if(GetComponentInParent<PlayerStates_Scr>().myPlayerStatusSt == PlayerStates_Scr.PlayerStatusStates.Dead)
        {
            if (backupList.Count != 0)
            {
                mainParentObject.transform.position = backupList[backupList.Count - 1].gameObject.transform.position;
                mainParentObject.transform.SetParent(backupList[backupList.Count - 1].transform);
                GetComponentInParent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                GetComponentInParent<PlayerStates_Scr>().myPlayerStatusSt = PlayerStates_Scr.PlayerStatusStates.Alive;
            }
            else
            {
                gameOverUI.SetActive(true);
                whatIsPaused.SetActive(false);
            }
        }
    }

    /*void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "FireWall" || otherObject.gameObject.tag == "OffObject")
        {
            GetComponentInParent<PlayerStates_Scr>().myPlayerStatusSt = PlayerStates_Scr.PlayerStatusStates.Dead;//maybe replace with a non update function
        }

        if (otherObject.gameObject.tag == "Robot" && otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Infected)
        {
            if (!backupList.Contains(otherObject.gameObject))
            {
                backupList.Add(otherObject.gameObject);
            }
        }
    }*/
}
