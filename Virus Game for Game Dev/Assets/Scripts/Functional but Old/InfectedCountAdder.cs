using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectedCountAdder : MonoBehaviour
{
    public Create_FloatVariable infectedCount;
    public bool objectState = false; // false = clean, true = infected

    private void OnTriggerEnter(Collider collideWith)
    {
        switch (objectState)
            {
                case false: 
                    if (collideWith.gameObject.tag == "Player") 
                    {
                        objectState = true;
                        infectedCount.value += 1;
                    }
                break;

                case true: 
                break;
            }
    }
}
