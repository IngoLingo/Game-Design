using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotControlerScript : MonoBehaviour
{
    public Create_FloatVariable playerSpeed;
    public float robotState = 1; //0 = off, 1 = clean, 2 = infected
    public Create_FloatVariable playerState;
    public float robotHP = 5;
    public float robotSpeed = 2;

    public Rigidbody damageBox;
    public Transform barrelEnd;
    public Transform eyePiviot;

    //Robot AI controles
    private bool pressUp   = false;
    private bool pressDown = false;
    private bool pressLeft = false;
    private bool pressRight = false;
    public bool pressAttack = false;

        private void Start()
        {
                StartCoroutine(Attacking());
        }

        private void Update() //private IEnumerator UpdateState()
        {
                //States
                if (robotState == 0) //Off
                {
                        if (robotHP <= 0) 
                        {
                                robotHP = 5;
                                pressAttack = true;
                                robotState = 1;
                        }
                        GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
                }
                else if (robotState == 1) //Clean
                {
                        if (robotHP <= 0) 
                        {
                                robotHP = 5;
                                pressAttack = false;
                                robotState = 2;
                        }
                        GetComponent<Renderer>().material.color = new Color(1f,0.5f,0.5f);

                        //If controles are true
                        if (pressUp == true)
                        {
                                transform.Translate(Vector3.forward * robotSpeed * Time.deltaTime);
                                eyePiviot.transform.rotation =  Quaternion.Euler(0, 90, 0);
                        }
                        if (pressDown == true)
                        {
                                transform.Translate(-Vector3.forward * robotSpeed * Time.deltaTime); 
                        }
                        if (pressLeft == true)
                        {
                                transform.Translate(-Vector3.right * playerSpeed.value * Time.deltaTime); 
                        }
                        if (pressRight == true)
                        {
                                transform.Translate(Vector3.right * playerSpeed.value * Time.deltaTime); 
                        }
                        if (pressAttack == true)
                        {
                                //
                        }
                }
                else if (robotState == 2) //Infected
                {
                        if (robotHP <= 0) 
                        {
                                robotHP = 5;
                                pressAttack = false;
                                robotState = 0;
                        }
                        GetComponent<Renderer>().material.color = new Color(0.5f,1f,0.5f);
                        pressAttack = false;
                }
        }

    private void OnTriggerStay(Collider otherObject)
    {
        if (otherObject.gameObject.tag == "Player" && playerState.value == 2)
        {    
                transform.rotation = otherObject.transform.rotation;
                otherObject.transform.SetParent(this.transform);
                if (robotHP <= 0) 
                {
                        //otherObject.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
                        playerState.value = 0;
                        return;
                }
                
            robotState = 2;

            //Forward 
            if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.O))
            {
                    transform.Translate(Vector3.forward * playerSpeed.value * Time.deltaTime);
                    eyePiviot.transform.rotation =  Quaternion.Euler(0, 0, 0); 
                    //otherObject.transform.position = transform.position; 
            }

            //Back 
            if(Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.O)) 
            {
                    transform.Translate(-Vector3.forward * playerSpeed.value * Time.deltaTime); 
                    eyePiviot.transform.rotation =  Quaternion.Euler(0, 180, 0);
                    //otherObject.transform.position = transform.position; 
            }

            //Left 
            if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.O)) 
            {
                    transform.Translate(-Vector3.right * playerSpeed.value * Time.deltaTime); 
                    eyePiviot.transform.rotation =  Quaternion.Euler(0, 270, 0);
                    //otherObject.transform.position = transform.position; 
            }

            //Right 
            if(Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.O)) 
            {
                    transform.Translate(Vector3.right * playerSpeed.value * Time.deltaTime); 
                    eyePiviot.transform.rotation =  Quaternion.Euler(0, 90, 0);
                    //otherObject.transform.position = transform.position; 
            }

            //Clear Firewall
            if(Input.GetKey(KeyCode.O)) 
            {
                //StartCoroutine(Clearing());
            }
        }
    }

    
    private IEnumerator Attacking()
    {
        yield return new WaitForSeconds(5f);
        if (pressAttack == true) 
        {
                Rigidbody rocketInstance;
                rocketInstance = Instantiate(damageBox, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
                StartCoroutine(Attacking());
        }
    }

}