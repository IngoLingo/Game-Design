using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour
{
    void Start() 
    {
        Debug.Log("START!");
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().material.color = new Color(0.5f,1,0.5f);
        Debug.Log("It Works!");
    }
}