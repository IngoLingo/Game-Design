using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameObjects_Scr : MonoBehaviour
{

    public Create_FloatVariable infectedPoints;

    void Start()
    {
        infectedPoints.value = 0;
    }
}
