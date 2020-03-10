using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKey(KeyCode.O)) 
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
