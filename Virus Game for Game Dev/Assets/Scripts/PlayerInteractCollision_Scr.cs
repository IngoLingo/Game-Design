using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInteractCollision_Scr : MonoBehaviour
{
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    //public UnityEvent TriggerStayEvent, TriggerExitEvent;

    public enum CollisionDirection {North, East, South, West};
    public CollisionDirection myCollisionDirectionSt;

    public bool interact = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.O)) 
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
        if (otherObject.gameObject.tag == "Robot") 
        {
            switch (myCollisionDirectionSt)
            {
                case CollisionDirection.North: 
                    if(Input.GetKey(KeyCode.W) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            //change state
                        }
                    break;
                    
                case CollisionDirection.East: 
                    if(Input.GetKey(KeyCode.D) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            //change state
                        }
                    break;
                    
                case CollisionDirection.South: 
                    if(Input.GetKey(KeyCode.S) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            //change state
                        }
                    break;
                    
                case CollisionDirection.West: 
                    if(Input.GetKey(KeyCode.A) && interact == true) 
                        {
                            transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                            //parent to robot
                            //change state
                        }
                    break;
            }
        }
    }
    
    private void OnTriggerExit(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Robot") 
        {
            //TriggerExitEvent.Invoke();
            Debug.Log("Miss Bot");
        }
    }
}
