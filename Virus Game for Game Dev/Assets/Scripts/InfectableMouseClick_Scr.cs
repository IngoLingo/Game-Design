using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfectableMouseClick_Scr : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject pausableObject;
    public GameObject playerDistanceCheck;
    public float distanceToOther = 1.5f;

    private void OnMouseDown()
    {
        float dist = Vector3.Distance(playerObject.transform.position, transform.position);

        switch (GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt)
        {
            case InfectableCollisionStates_Scr.ObjectStatusStates.Off:
                if (dist <= distanceToOther && playerObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot)
                {
                    GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt = InfectableCollisionStates_Scr.ObjectStatusStates.Infectable;
                }
                break;

            case InfectableCollisionStates_Scr.ObjectStatusStates.Firewall:
                if (dist <= distanceToOther && playerObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot)
                {
                    GetComponent<InfectableCollisionStates_Scr>().myObjectStatusSt = InfectableCollisionStates_Scr.ObjectStatusStates.Infectable;
                }
                break;

            case InfectableCollisionStates_Scr.ObjectStatusStates.Infectable:
                if (dist <= distanceToOther && playerObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt == PlayerStates_Scr.PlayerModeStates.Robot)
                {
                    playerObject.gameObject.transform.position = transform.position;
                    playerObject.gameObject.transform.SetParent(pausableObject.gameObject.transform);
                    playerObject.gameObject.GetComponent<PlayerStates_Scr>().myPlayerModeSt = PlayerStates_Scr.PlayerModeStates.Object;
                }
                break;
        }
    }
}

