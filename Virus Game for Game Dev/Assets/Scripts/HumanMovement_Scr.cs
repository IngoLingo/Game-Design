using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanMovement_Scr : MonoBehaviour
{
    public List<GameObject> targetList = new List<GameObject>();
    public GameObject target; //the enemy's target
    public float moveSpeed = 2; //move speed
    public float rotationSpeed = 10; //move speed
    public NavMeshAgent agent;

    private void Start()
    {
        targetList.Add(target.gameObject);
    }

    void Update()
    {
        //rotate to look at the target
        /*transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetList[targetList.Count-1].transform.position - transform.position), rotationSpeed * Time.deltaTime);

        //move towards the player
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
        */
        agent.SetDestination(targetList[targetList.Count - 1].transform.position);
    }
}
