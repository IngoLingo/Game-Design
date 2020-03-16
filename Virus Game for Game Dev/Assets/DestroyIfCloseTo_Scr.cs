using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfCloseTo_Scr : MonoBehaviour
{
    public GameObject objectToCheck;
    public GameObject objectToDestroy;

    public float distanceToCheck;

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(objectToCheck.transform.position, transform.position);

        if (dist <= distanceToCheck && objectToDestroy.activeSelf == true)
        {
            Destroy(objectToDestroy);
        }
    }
}
