using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame_scr : MonoBehaviour
{
    public GameObject objectToPause;
    public GameObject objectToUnPause;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            objectToUnPause.SetActive(true);
            objectToPause.SetActive(false);
        }
    }
}