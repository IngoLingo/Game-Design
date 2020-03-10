using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMovement_Scr : MonoBehaviour
{
    
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    public Create_FloatVariable playerSpeed;

    public GameObject target; //the enemy's target
    public float moveSpeed = 1; //move speed
    public float rotationSpeed = 5; //move speed


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<RobotStates_Scr>().myRobotModeSt == RobotStates_Scr.RobotModeStates.Move)
        {
            switch (GetComponent<RobotStates_Scr>().myRobotStatusSt)
            {
                case RobotStates_Scr.RobotStatusStates.Clean:
                    //rotate to look at the player
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position), rotationSpeed * Time.deltaTime);
                    
                    //move towards the player
                    transform.position += transform.forward * Time.deltaTime * moveSpeed;
                break;
                
                case RobotStates_Scr.RobotStatusStates.Infected:                
                    if (Input.GetKey(KeyCode.W))// && playerCollisionCheck.North == false) 
                    {
                        MoveNorth();
                    }
                    
                    if (Input.GetKey(KeyCode.D))// && playerCollisionCheck.East == false) 
                    {
                        MoveEast();
                    }

                    if (Input.GetKey(KeyCode.S))// && playerCollisionCheck.South == false) 
                    {
                        MoveSouth();
                    }
                    
                    if (Input.GetKey(KeyCode.A))// && playerCollisionCheck.West == false) 
                    {
                        MoveWest();
                    }
                break;
                
                case RobotStates_Scr.RobotStatusStates.Off:
                    //transform.rotation = Quaternion.identity;
                break;
            }
        }
    }


    //Functions
    void MoveNorth()
    {
        transform.Translate(Vector3.forward * playerSpeed.value * Time.deltaTime); 
    }

    void MoveEast()
    {
        transform.Translate(Vector3.right * playerSpeed.value * Time.deltaTime); 
    }

    void MoveSouth()
    {
        transform.Translate(-Vector3.forward * playerSpeed.value * Time.deltaTime); 
    }

    void MoveWest()
    {
        transform.Translate(-Vector3.right * playerSpeed.value * Time.deltaTime); 
    }
}
