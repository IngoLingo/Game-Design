using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player2DCollision_Scr : MonoBehaviour
{
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    public UnityEvent CollideTrueEvent, CollideFalseEvent, ResetCollisionEvent;

    private void Start()
    {
        ResetCollisionEvent.Invoke();
    }
    private void OnEnable()
    {
        ResetCollisionEvent.Invoke();
    }

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (transform.parent.GetComponent<Player2DStates_Scr>().myPlayerModeSt == Player2DStates_Scr.PlayerModeStates.Object) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision" || otherObject.gameObject.tag == "FireWall") 
            {
                CollideFalseEvent.Invoke();
            }
        }
        else
        if (transform.parent.GetComponent<Player2DStates_Scr>().myPlayerModeSt == Player2DStates_Scr.PlayerModeStates.Robot) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision" || otherObject.gameObject.tag == "FireWall") 
            {
                CollideTrueEvent.Invoke();
            }
        }
        
        //Can't collide with these objects, no mater the state
        if (otherObject.gameObject.tag == "WallCollision" || otherObject.gameObject.tag == "OffObject") 
        {
            CollideTrueEvent.Invoke();
        }
    }
    
    private void OnTriggerExit(Collider otherObject)
	{
        if (transform.parent.GetComponent<Player2DStates_Scr>().myPlayerModeSt == Player2DStates_Scr.PlayerModeStates.Object) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision" || otherObject.gameObject.tag == "FireWall") 
            {
                CollideTrueEvent.Invoke();
            }
        }
        else
        if (transform.parent.GetComponent<Player2DStates_Scr>().myPlayerModeSt == Player2DStates_Scr.PlayerModeStates.Robot) 
        {
            if (otherObject.gameObject.tag == "InfectableObjectCollision" || otherObject.gameObject.tag == "FireWall") 
            {
                CollideFalseEvent.Invoke();
            }
        }
        
        //Un-collide with these objects, no mater the state
        if (otherObject.gameObject.tag == "WallCollision" || otherObject.gameObject.tag == "OffObject") 
        {
            CollideFalseEvent.Invoke();
        }
    }
}
