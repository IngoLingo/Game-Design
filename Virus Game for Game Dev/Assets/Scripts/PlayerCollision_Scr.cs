using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision_Scr : MonoBehaviour
{
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    public UnityEvent TriggerStayEvent, TriggerExitEvent;

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Object) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                TriggerStayEvent.Invoke();
            }
        }
        else
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                TriggerStayEvent.Invoke();
            }
        }
    }
    
    private void OnTriggerExit(Collider otherObject)
	{
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Object) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                TriggerExitEvent.Invoke();
            }
        }
        else
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                TriggerExitEvent.Invoke();
            }
        }
    }
}
