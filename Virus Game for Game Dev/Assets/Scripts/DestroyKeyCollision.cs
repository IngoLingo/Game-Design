using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKeyCollision : MonoBehaviour
{
    public float inectedRequired;
    public Create_FloatVariable infectedCount;

private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player" && infectedCount.value >= inectedRequired)
        {
            Destroy(gameObject);
        }
    }
}
