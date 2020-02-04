using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerSideCollision : MonoBehaviour
{
    public float direction; //0 = forward, 1 = back, 2 = left, 3 = right
    public Create_FloatVariable playerSpeed;
    public GameObject objectMoved;
    
    void Start() 
    {
        //var objectMoved = transform.parent.gameObject;
    }
    //GameObject objectMoved = transform.gameObject;

    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "InfectableObjectCollision")
        {
            switch (direction)
            {
                case 0:  //Forward 
                    if(Input.GetKey(KeyCode.W)) 
                        {
                                objectMoved.transform.Translate(Vector3.forward * playerSpeed.value * Time.deltaTime);
                        }
                    break;

                case 1:  //Back 
                    if(Input.GetKey(KeyCode.S)) 
                        {
                                objectMoved.transform.Translate(-Vector3.forward * playerSpeed.value * Time.deltaTime);
                        }
                    break;
                    
                case 2:  //Left 
                    if(Input.GetKey(KeyCode.A)) 
                        {
                                objectMoved.transform.Translate(-Vector3.right * playerSpeed.value * Time.deltaTime);
                        }
                    break;

                case 3:  //Right 
                    if(Input.GetKey(KeyCode.D)) 
                        {
                                objectMoved.transform.Translate(Vector3.right * playerSpeed.value * Time.deltaTime);
                        }
                    break;
                    
                default: //Nothing
                    break;
            }
        }
    }
	
    
    

        
    
}
