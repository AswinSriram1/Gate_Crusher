using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quitting()
    {
        Application.Quit();
    }
}
