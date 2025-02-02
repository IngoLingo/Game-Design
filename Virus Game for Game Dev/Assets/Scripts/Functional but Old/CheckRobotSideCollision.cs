﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRobotSideCollision : MonoBehaviour
{
    public float direction; //0 = forward, 1 = back, 2 = left, 3 = right
    //public Create_FloatVariable myState; //0 = paused, 1 = infecting objects, 2 = infecting robots, 3 = death (more to add)
    public Create_FloatVariable playerSpeed;

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        Debug.Log("collided with " + otherObject.gameObject.tag);
        if (this.transform.parent.GetComponent<RobotControlerScript>().robotState == 1)
        {
            /*if (otherObject.gameObject.tag == "InfectableObjectCollision")
            {
                switch (direction)
                {
                    case 0:  //Forward 
                        if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.O)) 
                            {
                                transform.parent.gameObject.transform.Translate(Vector3.forward * playerSpeed.value * Time.deltaTime);
                            }
                        break;

                    case 1:  //Back 
                        if(Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.O)) 
                            {
                                transform.parent.gameObject.transform.Translate(-Vector3.forward * playerSpeed.value * Time.deltaTime);
                            }
                        break;
                        
                    case 2:  //Left 
                        if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.O)) 
                            {
                                transform.parent.gameObject.transform.Translate(-Vector3.right * playerSpeed.value * Time.deltaTime);
                            }
                        break;

                    case 3:  //Right 
                        if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.O)) 
                            {
                                transform.parent.gameObject.transform.Translate(Vector3.right * playerSpeed.value * Time.deltaTime);
                            }
                        break;
                        
                    default: //Nothing
                        break;
                }
            }*/
        }
    }
}
