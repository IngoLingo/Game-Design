using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatesControlerScript : MonoBehaviour
{
    public Create_FloatVariable myState;

    // Start
    void Start()
    {
        myState.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Check Triggers
    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "InfectableObjectCollision")
        {
            myState.value = 1f;
        }

        if (otherObject.gameObject.tag == "Robot")
        {
            myState.value = 2f;
        }
    }
}
