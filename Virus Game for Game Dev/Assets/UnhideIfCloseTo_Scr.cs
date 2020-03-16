using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnhideIfCloseTo_Scr : MonoBehaviour
{
    public GameObject objectToCheck;
    public GameObject objectToUnhide;
    public GameObject checkIfHidden;

    public float distanceToCheck;
    public bool needBot;
    public bool checkHidden;


    void Update()
    {
        float dist = Vector3.Distance(objectToCheck.transform.position, transform.position);

        if (checkHidden == true)
        {
            if (checkIfHidden.activeSelf == false)
            {
                objectToUnhide.SetActive(false);
                return;
            }
        }

        if (needBot == false)
        {
            if (dist <= distanceToCheck)
            {
                objectToUnhide.SetActive(true);
            }
            else
            {
                objectToUnhide.SetActive(false);
            }
        }
        else if (needBot == true)
        {
            if (dist <= distanceToCheck && objectToCheck.gameObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot)
            {
                objectToUnhide.SetActive(true);
            }
            else
            {
                objectToUnhide.SetActive(false);
            }
        }
    }
}
