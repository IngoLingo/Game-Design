using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates_Scr : MonoBehaviour
{
    public Create_FloatVariable playerSpeed;
    public Create_4DirectionCollisionCheck playerCollisionCheck;
    
    public enum PlayerModeStates {Object, Robot, Key};
    public enum PlayerStatusStates {Alive, Stun, Dead};

    public PlayerModeStates myPlayerModeSt;
    public PlayerStatusStates myPlayerStatusSt;

    public float test = 0f;

    void Start()
    {
        myPlayerModeSt = PlayerModeStates.Object;

        myPlayerStatusSt = PlayerStatusStates.Alive;
    }

    void Update()
    {
        if (myPlayerModeSt == PlayerModeStates.Object)
        {
            if (Input.GetKey(KeyCode.W) && playerCollisionCheck.North == false) 
            {
                MoveNorth();
            }
            
            if (Input.GetKey(KeyCode.D) && playerCollisionCheck.East == false) 
            {
                MoveEast();
            }

            if (Input.GetKey(KeyCode.S) && playerCollisionCheck.South == false) 
            {
                MoveSouth();
            }
            
            if (Input.GetKey(KeyCode.A) && playerCollisionCheck.West == false) 
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
