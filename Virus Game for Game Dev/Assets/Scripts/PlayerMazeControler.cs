﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMazeControler : MonoBehaviour
{
    //movement speed in units per second
    public float movementSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        //transform.position = Input.mousePosition;
        
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
        
    }
}
