using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollision_Scr : MonoBehaviour
{
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    public UnityEvent CollideTrueEvent, CollideFalseEvent;

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Object) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                CollideFalseEvent.Invoke();
            }
        }
        else
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                CollideTrueEvent.Invoke();
            }
        }
        
        //Can't collide with these objects, no mater the state
        if (otherObject.gameObject.tag == "WallCollision") 
        {
            CollideTrueEvent.Invoke();
        }
    }
    
    private void OnTriggerExit(Collider otherObject)
	{
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Object) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                CollideTrueEvent.Invoke();
            }
        }
        else
        if (transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision") 
            {
                CollideFalseEvent.Invoke();
            }
        }
        
        //Un-collide with these objects, no mater the state
        if (otherObject.gameObject.tag == "WallCollision") 
        {
            CollideFalseEvent.Invoke();
        }
    }
}
