using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectableCollisionStates_Scr : MonoBehaviour
{
    public enum ObjectStatusStates {Infectable, Off, Firewall};
    public ObjectStatusStates myObjectStatusSt;

    public GameObject childOffObj;
    public GameObject childInfectableObj;
    public GameObject childFireWallObj;
    
    void Start()
    {
        if (myObjectStatusSt == ObjectStatusStates.Off)
            {
                TurnOff();
            }
        
        if (myObjectStatusSt == ObjectStatusStates.Infectable)
            {
                InfectableUp();
            }
        
        if (myObjectStatusSt == ObjectStatusStates.Firewall)
            {
                FireWallUp();
            }
    }

    //May need to replace with something that dosent run all the time
    void Update()
    {
        if (myObjectStatusSt == ObjectStatusStates.Off)
            {
                TurnOff();
            }
        
        if (myObjectStatusSt == ObjectStatusStates.Infectable)
            {
                InfectableUp();
            }
        
        if (myObjectStatusSt == ObjectStatusStates.Firewall)
            {
                FireWallUp();
            }
    }

    void TurnOff()
    {
        childOffObj.SetActive(true);
        childInfectableObj.SetActive(false);
        childFireWallObj.SetActive(false);
    }

    void InfectableUp()
    {
        childOffObj.SetActive(false);
        childInfectableObj.SetActive(true);
        childFireWallObj.SetActive(false);
    }

    void FireWallUp()
    {
        childOffObj.SetActive(false);
        childInfectableObj.SetActive(false);
        childFireWallObj.SetActive(true);
    }
}