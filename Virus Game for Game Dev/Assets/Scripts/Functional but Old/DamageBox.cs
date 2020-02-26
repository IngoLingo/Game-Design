using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBox : MonoBehaviour
{
    public float damage = 1;
    public Rigidbody fireWall;
    public Transform spawn;
    private bool skipLine = false;

    private void Start()
    {
        StartCoroutine(Timer());
    }

    private void OnTriggerEnter(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "InfectableObjectCollision" && otherObject.GetComponent<InfectedControler>().infectedState == 0)
        {
            if (skipLine == false) 
            {
                transform.position = otherObject.transform.position;
                otherObject.GetComponent<InfectedControler>().infectedState = 1;
                StartCoroutine(FireWall());
            }
            skipLine = true;
        } 
        if (otherObject.gameObject.tag == "Robot")
        {
            if (skipLine == false) 
            {
                otherObject.GetComponent<RobotControlerScript>().robotHP -= damage;
            }
            Destroy(gameObject);
            skipLine = true;
        }
        if (skipLine == false) 
        {
            StartCoroutine(Timer());
        }
    }
    
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.1f);
        if (skipLine == false) 
        {
            Destroy(gameObject);
        }
    }
    
    private IEnumerator FireWall()
    {  
        yield return new WaitForSeconds(5f);
        Rigidbody fireWallInstance;
        fireWallInstance = Instantiate(fireWall, spawn.position, Quaternion.identity) as Rigidbody;
        Destroy(gameObject);
    }
}