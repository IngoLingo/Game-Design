﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKeyCollision : MonoBehaviour
{
    public float inectedRequired;
    public Create_FloatVariable infectedCount;
    
    public static bool GameIsPaused;
    public GameObject mazeGameUI;
    public GameObject whatIsPaused;

    void Start()
    {
        Resume();
    }

    private void OnTriggerStay(Collider otherObject)
	{
        if (otherObject.gameObject.tag == "Player" && infectedCount.value >= inectedRequired)
        {
            Pause();
            Destroy(gameObject);
        }
    }
    
    void Resume()
    {
        mazeGameUI.SetActive(false);
        whatIsPaused.SetActive(true);
        GameIsPaused = false;
    }

    void Pause()
    {
        mazeGameUI.SetActive(true);
        whatIsPaused.SetActive(false);
        GameIsPaused = true;
    }
}