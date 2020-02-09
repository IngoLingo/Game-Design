using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatesControlerScript : MonoBehaviour
{
    public Create_FloatVariable myState;
    public Create_FloatVariable infectedCount;

    void Awake()
    {
        infectedCount.value = 0f;
        myState.value = 1f;
    }
    
    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "FireWall")
        {
            myState.value = 3f;
        }
    }
}
