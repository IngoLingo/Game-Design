using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSight : MonoBehaviour
{
    /*
    public Transform following;

    void Update()
    {
        if (gameObject.GetComponent<RobotControlerScript>().robotState == 1)
        {
            // Move our position a step closer to the target.
            float robotSpeed =  1f * Time.deltaTime;
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, following.transform.position, robotSpeed);
        }
    }
*/
 
    public GameObject target; //the enemy's target
    public float moveSpeed = 1; //move speed
    public float rotationSpeed = 5; //speed of turning
    //private Rigidbody rb;
    //private Vector3 mytransform = target;
/*
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
*/

    void Update()
    {
        if (gameObject.GetComponent<RobotControlerScript>().robotState == 1)
        {
            //rotate to look at the player
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position), rotationSpeed * Time.deltaTime);

            //move towards the player
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }

    }
 
}
