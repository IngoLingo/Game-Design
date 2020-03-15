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
        agent.SetDestination(targetList[targetList.Count - 1].transform.position);
    }
}
