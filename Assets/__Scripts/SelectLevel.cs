using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void Level1Button()
    {
        LoadLevel(0);
    }
    public void Level2Button()
    {
        LoadLevel(1);
    }
    public void Level3Button()
    {
        LoadLevel(2);
    }
    public void Level4Button()
    {
        LoadLevel(3);
    }
    
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void LoadLevel(int levelIndex)
    {
        MissionDemolition.SET_START_LEVEL(levelIndex);
        SceneManager.LoadScene("_Scene_0");
    }
}
