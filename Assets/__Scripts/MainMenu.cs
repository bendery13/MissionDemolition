using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
    public void StartButton()
    {
        MissionDemolition.START_FROM_MAIN_MENU();
        SceneManager.LoadScene("_Scene_0");
    }
    public void SelectLevelButton()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
