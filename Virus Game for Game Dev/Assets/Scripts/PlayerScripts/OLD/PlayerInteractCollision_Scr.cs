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

    public GameObject pausableObj;

    public bool interact = false;
    //private bool skipLine = false;

    private void OnDisable()
    {
        interact = false;
    }
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
        //Interact with Firewall and off object
        if ((otherObject.gameObject.tag == "FireWall" || otherObject.gameObject.tag == "OffObject")
            && transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot) 
        {
            switch (myCollisionDirectionSt)
            {
                case CollisionDirection.North: 
                    if(Input.GetKey(KeyCode.W) && interact == true) 
                        {
                            otherObject.transform.parent.GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt = InfectableCollisionStates_Scr.ObjectStatusStates.Infectable;
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.East: 
                    if(Input.GetKey(KeyCode.D) && interact == true) 
                        {
                            otherObject.transform.parent.GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt = InfectableCollisionStates_Scr.ObjectStatusStates.Infectable;
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.South: 
                    if(Input.GetKey(KeyCode.S) && interact == true) 
                        {
                            otherObject.transform.parent.GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt = InfectableCollisionStates_Scr.ObjectStatusStates.Infectable;
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.West: 
                    if(Input.GetKey(KeyCode.A) && interact == true) 
                        {
                            otherObject.transform.parent.GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt = InfectableCollisionStates_Scr.ObjectStatusStates.Infectable;
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
                            this.transform.parent.transform.SetParent(pausableObj.transform);
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                            AllTrueCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.East: 
                    if(Input.GetKey(KeyCode.D) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            this.transform.parent.transform.SetParent(pausableObj.transform);
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                            AllTrueCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.South: 
                    if(Input.GetKey(KeyCode.S) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            this.transform.parent.transform.SetParent(pausableObj.transform);
                            transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                            AllTrueCollisions();
                            interact = false;
                        }
                    break;
                    
                case CollisionDirection.West: 
                    if(Input.GetKey(KeyCode.A) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            this.transform.parent.transform.SetParent(pausableObj.transform);
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
                            if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt != RobotStates_Scr.RobotStatusStates.Off)
                            {
                                otherObject.transform.rotation = Quaternion.identity;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                this.transform.parent.transform.SetParent(otherObject.transform);
                                transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                                AllFalseCollisions();
                                interact = false;
                            }
                            else if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Off)
                            {
                                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Clean;
                                interact = false;
                            }
                        }
                    break;
                    
                case CollisionDirection.East: 
                    if(Input.GetKey(KeyCode.D) && interact == true) 
                        {
                            if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean ||
                                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Infected)
                            {
                                otherObject.transform.rotation = Quaternion.identity;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                this.transform.parent.transform.SetParent(otherObject.transform);
                                transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                                AllFalseCollisions();
                                interact = false;
                            }
                            else if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Off)
                            {
                                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Clean;
                                interact = false;
                            }
                        }
                    break;
                    
                case CollisionDirection.South: 
                    if(Input.GetKey(KeyCode.S) && interact == true) 
                        {
                            if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean ||
                                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Infected)
                            {
                                otherObject.transform.rotation = Quaternion.identity;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                this.transform.parent.transform.SetParent(otherObject.transform);
                                transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                                AllFalseCollisions();
                                interact = false;
                            }
                            else if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Off)
                            {
                                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Clean;
                                interact = false;
                            }
                        }
                    break;
                    
                case CollisionDirection.West: 
                    if(Input.GetKey(KeyCode.A) && interact == true) 
                        {
                            if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Clean ||
                                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Infected)
                            {
                                otherObject.transform.rotation = Quaternion.identity;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                this.transform.parent.transform.SetParent(otherObject.transform);
                                transform.parent.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Robot;
                                AllFalseCollisions();
                                interact = false;
                            }
                            else if (otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt == RobotStates_Scr.RobotStatusStates.Off)
                            {
                                otherObject.GetComponent<RobotStates_Scr>().myRobotStatusSt = RobotStates_Scr.RobotStatusStates.Clean;
                                interact = false;
                            }
                        }
                    break;
            }
        }
        
        //interact = false;
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

    //Corutine

}
