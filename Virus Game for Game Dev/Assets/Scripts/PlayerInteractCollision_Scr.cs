using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractCollision_Scr : MonoBehaviour
{
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    public UnityEvent InvokeAllTrue, InvokeAllFalse;

    public enum CollisionDirection {North, East, South, West};
    public CollisionDirection myCollisionDirectionSt;

    public bool interact = false;
    //private bool skipLine = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) 
		{
            interact = true;
        }
        else
        if (Input.GetKeyUp(KeyCode.O)) 
		{
            interact = false;
        }
    }

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        //Interact with Firewall
        if (otherObject.gameObject.tag == "FireWall" && transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot) 
        {
            Debug.Log("FireWall");
            switch (myCollisionDirectionSt)
            {
                case CollisionDirection.North: 
                    if(Input.GetKey(KeyCode.W) && interact == true) 
                        {
                            Destroy(otherObject.gameObject);
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.East: 
                    if(Input.GetKey(KeyCode.D) && interact == true) 
                        {
                            Destroy(otherObject.gameObject);
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.South: 
                    if(Input.GetKey(KeyCode.S) && interact == true) 
                        {
                            Destroy(otherObject.gameObject);
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.West: 
                    if(Input.GetKey(KeyCode.A) && interact == true) 
                        {
                            Destroy(otherObject.gameObject);
                            interact = false;
                        }
                    break;
            }
        }

        //Jump to Object
        if (otherObject.gameObject.tag == "InfectableObjectCollision" && transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot) 
        {
            switch (myCollisionDirectionSt)
            {
                case CollisionDirection.North: 
                    if(Input.GetKey(KeyCode.W) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //unparent robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                            AllTrueCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.East: 
                    if(Input.GetKey(KeyCode.D) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //unparent robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                            AllTrueCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.South: 
                    if(Input.GetKey(KeyCode.S) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //unparent robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                            AllTrueCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.West: 
                    if(Input.GetKey(KeyCode.A) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //unparent robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                            AllTrueCollisions();
                            interact = false;
                        }
                    break;
            }
        }
        
        //Jump to Robot
        if (otherObject.gameObject.tag == "Robot") 
        {
            switch (myCollisionDirectionSt)
            {
                case CollisionDirection.North: 
                    if(Input.GetKey(KeyCode.W) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                            AllFalseCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.East: 
                    if(Input.GetKey(KeyCode.D) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                            AllFalseCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.South: 
                    if(Input.GetKey(KeyCode.S) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                            AllFalseCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.West: 
                    if(Input.GetKey(KeyCode.A) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                            AllFalseCollisions();
                            interact = false;
                        }
                    break;
            }
        }
        
        interact = false;
    }
    
    private void OnTriggerExit(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Robot") 
        {
            //TriggerExitEvent.Invoke();
            Debug.Log("Miss Bot");
        }
    }

    //Functions
    void AllTrueCollisions()
    {
        InvokeAllTrue.Invoke();
    }
    void AllFalseCollisions()
    {
        InvokeAllFalse.Invoke();
    }
}
