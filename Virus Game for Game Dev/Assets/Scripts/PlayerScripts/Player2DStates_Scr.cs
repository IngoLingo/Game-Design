using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DStates_Scr : MonoBehaviour
{
    public Create_FloatVariable playerSpeed;
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    
    public enum PlayerModeStates {Object, Robot, Key};
    public enum PlayerStatusStates {Alive, Stun, Dead};

    public PlayerModeStates myPlayerModeSt;
    public PlayerStatusStates myPlayerStatusSt;

    //public float test = 0f;

    void Start()
    {
        myPlayerModeSt = PlayerModeStates.Object;

        myPlayerStatusSt = PlayerStatusStates.Alive;
    }

    void Update()
    {
        if (myPlayerModeSt == PlayerModeStates.Object)
        {
            if (Input.GetAxis("Vertical") > 0 && playerCollisionCheck.North == false) 
            {
                MoveNorth();
            }
            
            if (Input.GetAxis("Horizontal") > 0 && playerCollisionCheck.East == false) 
            {
                MoveEast();
            }

            if (Input.GetAxis("Vertical") < 0 && playerCollisionCheck.South == false) 
            {
                MoveSouth();
            }
            
            if (Input.GetAxis("Horizontal") < 0 && playerCollisionCheck.West == false) 
            {
                MoveWest();
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
