using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackDeath : MonoBehaviour
{
    public Create_FloatVariable playerState;
    public GameObject gameOverUI;


    // Update is called once per frame
    void Update()
    {
        if (playerState.value == 0) 
        {
            Pause();
            if (Input.GetKey(KeyCode.O))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
        else
        {
            Resume();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playerState.value = 0;
        }
    }
    
    void Resume()
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
