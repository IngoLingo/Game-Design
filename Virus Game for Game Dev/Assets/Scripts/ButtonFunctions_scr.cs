using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions_scr : MonoBehaviour
{
    public void doQuit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
    public void playGame()
    {
        SceneManager.LoadScene("Main_Game", LoadSceneMode.Single);
    }
}