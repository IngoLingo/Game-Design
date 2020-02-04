using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControlerScript : MonoBehaviour
{
	//public GameObject objectMoved;
    public Create_FloatVariable playerSpeed;

    private void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "Player")
        {
            //Forward 
            if(Input.GetKey(KeyCode.W)) 
            {
                //if
                    transform.Translate(Vector3.forward * playerSpeed.value * Time.deltaTime); 
            }

            //Back 
            if(Input.GetKey(KeyCode.S)) 
            {
                //if
                    transform.Translate(-Vector3.forward * playerSpeed.value * Time.deltaTime); 
            }

            //Left 
            if(Input.GetKey(KeyCode.A)) 
            {
                //if
                    transform.Translate(-Vector3.right * playerSpeed.value * Time.deltaTime); 
            }

            //Right 
            if(Input.GetKey(KeyCode.D)) 
            {
                //if
                    transform.Translate(Vector3.right * playerSpeed.value * Time.deltaTime); 
            }
        }
    }
}