using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HumanMovement_Scr : MonoBehaviour
{
    public List<GameObject> targetList = new List<GameObject>();
    public GameObject target; //the enemy's target
    public GameObject doorCheck; //the enemy's target
    public float moveSpeed = 2; //move speed
    public float rotationSpeed = 10; //move speed
    public NavMeshAgent agent;
    public bool isMoving = false;

    private void Start()
    {
        targetList.Add(target.gameObject);
    }

    void Update()
    {
        if (doorCheck.GetComponent<DoorStates_Scr>().myDoorStatusSt == DoorStates_Scr.DoorStatusStates.Infected)
        {
            isMoving = true;
        }
        if (isMoving == true)
        {
            HumanPriority();
        }
    }

    void HumanPriority()
    {
        float dist = Vector3.Distance(targetList[targetList.Count - 1].transform.position, transform.position);


        for (int i = 0; i < targetList.Count; i++)
        {
            //Debug.Log("Target number: " + targetList[i].name);
            dist = Vector3.Distance(targetList[i].transform.position, transform.position);

            if (dist <= 15f)
            {
                agent.SetDestination(targetList[i].transform.position);
                break;
            }
        }

        //do a loop and check what object is clossest and then move down the list, then bump up the distance check until a forth of the level is checked.
    }
}
