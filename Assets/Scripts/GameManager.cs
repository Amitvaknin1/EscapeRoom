using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WinCon;
    public void EndScreen()
    { 
        if (WinCon.activeInHierarchy == true)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
