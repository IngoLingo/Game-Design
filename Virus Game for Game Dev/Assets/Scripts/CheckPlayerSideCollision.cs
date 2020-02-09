using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerSideCollision : MonoBehaviour
{
    public float direction; //0 = forward, 1 = back, 2 = left, 3 = right
    public Create_FloatVariable myState; //0 = paused, 1 = infecting objects, 2 = infecting robots, 3 = death (more to add)
    public Create_FloatVariable playerSpeed;


    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        switch (myState.value)
        {
            //paused
            case 0:
            break;

            //infecting objects
            case 1:
                if (otherObject.gameObject.tag == "InfectableObjectCollision")
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
                }

                if (otherObject.gameObject.tag == "Robot" && otherObject.GetComponent<RobotControlerScript>().robotState != 0)
                {
                    switch (direction)
                    {
                        case 0:  //Forward 
                            if(Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.O)) 
                                {
                                    transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    myState.value = 2f;
                                }
                            break;

                        case 1:  //Back 
                            if(Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.O)) 
                                {
                                    transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    myState.value = 2f;
                                }
                            break;
                            
                        case 2:  //Left 
                            if(Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.O)) 
                                {
                                    transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    myState.value = 2f;
                                }
                            break;

                        case 3:  //Right 
                            if(Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.O)) 
                                {
                                    transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    myState.value = 2f;
                                }
                            break;
                            
                        default: //Nothing
                            break;
                    }
                }
            break;

            //infecting robot
            case 2:
            if (otherObject.gameObject.tag == "InfectableObjectCollision")
            {
                switch (direction)
                    {
                        case 0:  //Forward 
                            if(Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.O))
                            {
                                myState.value = 1f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;

                        case 1:  //Back 
                            if(Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.O))  
                            {
                                myState.value = 1f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;
                            
                        case 2:  //Left 
                            if(Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.O))  
                            {
                                myState.value = 1f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;

                        case 3:  //Right 
                            if(Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.O))  
                            {
                                myState.value = 1f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;
                            
                        default: //Nothing
                            break;
                    }
            }

            if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState != 0)
            {
                switch (direction)
                    {
                        case 0:  //Forward 
                            if(Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.O))
                            {
                                myState.value = 2f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;

                        case 1:  //Back 
                            if(Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.O))  
                            {
                                myState.value = 2f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;
                            
                        case 2:  //Left 
                            if(Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.O))  
                            {
                                myState.value = 2f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;

                        case 3:  //Right 
                            if(Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.O))  
                            {
                                myState.value = 2f;
                                transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;   
                            }                     
                            break;
                            
                        default: //Nothing
                            break;
                    }
            }
            
            if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState == 0)
            {
                switch (direction)
                    {
                        case 0:  //Forward 
                            if(Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.O))
                            {
                                otherObject.GetComponent<RobotControlerScript>().robotHP -= 3; 
                            }                     
                            break;

                        case 1:  //Back 
                            if(Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.O))  
                            {
                                otherObject.GetComponent<RobotControlerScript>().robotHP -= 3; 
                            }                     
                            break;
                            
                        case 2:  //Left 
                            if(Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.O))  
                            {
                                otherObject.GetComponent<RobotControlerScript>().robotHP -= 3; 
                            }                     
                            break;

                        case 3:  //Right 
                            if(Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.O))  
                            {
                                otherObject.GetComponent<RobotControlerScript>().robotHP -= 3; 
                            }                     
                            break;
                            
                        default: //Nothing
                            break;
                    }
            }
            /*
            if (otherObject.gameObject.tag == "InfectableObjectCollision" || otherObject.gameObject.tag == "Robot")
                {
                    switch (direction)
                    {
                        case 0:  //Forward 
                            if(Input.GetKey(KeyCode.W) && Input.GetKeyDown(KeyCode.O)) 
                                {
                                    if (otherObject.gameObject.tag == "InfectableObjectCollision")
                                    {
                                        myState.value = 1f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState != 0)
                                    {
                                        myState.value = 2f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState == 0)
                                    {
                                        //otherObject.GetComponent<RobotControlerScript>().robotState = 1;
                                    }
                            break;

                        case 1:  //Back 
                            if(Input.GetKey(KeyCode.S) && Input.GetKeyDown(KeyCode.O))  
                                {
                                    if (otherObject.gameObject.tag == "InfectableObjectCollision")
                                    {
                                        myState.value = 1f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState != 0)
                                    {
                                        myState.value = 2f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState == 0)
                                    {
                                        //otherObject.GetComponent<RobotControlerScript>().robotState = 1;
                                    }
                            break;
                            
                        case 2:  //Left 
                            if(Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.O))  
                                {
                                    if (otherObject.gameObject.tag == "InfectableObjectCollision")
                                    {
                                        myState.value = 1f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState != 0)
                                    {
                                        myState.value = 2f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState == 0)
                                    {
                                        //otherObject.GetComponent<RobotControlerScript>().robotState = 1;
                                    }
                            break;

                        case 3:  //Right 
                            if(Input.GetKey(KeyCode.D) && Input.GetKeyDown(KeyCode.O))  
                                {
                                    if (otherObject.gameObject.tag == "InfectableObjectCollision")
                                    {
                                        myState.value = 1f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState != 0)
                                    {
                                        myState.value = 2f;
                                        transform.parent.gameObject.transform.position = otherObject.gameObject.transform.position;
                                    }
                                    else if (otherObject.gameObject.tag == "Robot"  && otherObject.GetComponent<RobotControlerScript>().robotState == 0)
                                    {
                                        //otherObject.GetComponent<RobotControlerScript>().robotState = 1;
                                    }
                                }
                            break;
                            
                        default: //Nothing
                            break;
                    }
                }
            */
            break;

            //death
            case 3:
            break;

        }
    }
	
    
    

        
    
}
