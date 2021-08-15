using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Script_StartMenu : MonoBehaviour
{
    public void GoToStart()
    {
        Debug.Log("Pressed to Start Button");
    }

    public void GoToResume()
    {
        Debug.Log("Pressed Return Button");
    }
    public void GoToLoad()
    {
        Debug.Log("Pressed to Load Button");
    }
    public void GoToSettings()
    {
        Debug.Log("Pressed to Settings Button");
    }
    public void GoToQuit ()
    {
        Debug.Log("Pressed to Quit Button");
        Application.Quit();
    }
}
