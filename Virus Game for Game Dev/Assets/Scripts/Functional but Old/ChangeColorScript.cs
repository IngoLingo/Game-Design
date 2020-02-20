using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorScript : MonoBehaviour
{
    //public GameObject collideWith;

    private void OnTriggerEnter(Collider collideWith)
    {
        if (collideWith.gameObject.tag == "Player") {
            GetComponent<Renderer>().material.color = new Color(0.5f,1,0.5f);
        }
    }
}