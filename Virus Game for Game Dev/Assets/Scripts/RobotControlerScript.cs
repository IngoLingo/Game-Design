using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControlerScript : MonoBehaviour
{
    public Create_FloatVariable playerSpeed;
    public float robotState = 0;
    public Create_FloatVariable playerState;

    private void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "Player" && playerState.value == 2)
        {
                robotState = 1;
            //Forward 
            if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.O))
            {
                    transform.Translate(Vector3.forward * playerSpeed.value * Time.deltaTime); 
                    otherObject.transform.position = transform.position; 
            }

            //Back 
            if(Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.O)) 
            {
                    transform.Translate(-Vector3.forward * playerSpeed.value * Time.deltaTime); 
                    otherObject.transform.position = transform.position; 
            }

            //Left 
            if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.O)) 
            {
                    transform.Translate(-Vector3.right * playerSpeed.value * Time.deltaTime); 
                    otherObject.transform.position = transform.position; 
            }

            //Right 
            if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.O)) 
            {
                    transform.Translate(Vector3.right * playerSpeed.value * Time.deltaTime); 
                    otherObject.transform.position = transform.position; 
            }
            if(Input.GetKey(KeyCode.O)) 
            {
                robotState = 0;
                Debug.Log("NOT collided with player!");
            }
        }
    }
}