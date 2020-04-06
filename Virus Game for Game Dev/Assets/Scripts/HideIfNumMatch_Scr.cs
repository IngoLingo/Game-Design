using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideIfNumMatch_Scr : MonoBehaviour
{
    public Create_FloatVariable scriptableObjectHere;
    public GameObject objectToHide;

    void Update() //Use the update method anthony showed us
    {
        if (scriptableObjectHere.value > GetComponent<DoorMouseClick_Scr>().inectedRequired)
        {
            objectToHide.SetActive(false);
        }
        else
        {
            objectToHide.SetActive(true);
        }
    }
}
