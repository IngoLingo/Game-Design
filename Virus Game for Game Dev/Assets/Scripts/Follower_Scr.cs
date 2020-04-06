using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower_Scr : MonoBehaviour
{
    public GameObject target; //the enemy's target
    public float moveSpeed = 1; //move speed

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * moveSpeed);//target.transform.position * Time.deltaTime * moveSpeed; ;
    }
}
