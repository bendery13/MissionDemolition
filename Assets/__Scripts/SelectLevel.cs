using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    [SerializeField] private GameObject[] trophyIcons;

    void Start()
    {
        RefreshTrophies();
    }

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

    public void ResetProgressButton()
    {
        int levelCount = trophyIcons != null ? trophyIcons.Length : 0;
        for (int i = 0; i < levelCount; i++)
        {
            PlayerPrefs.DeleteKey("LevelCompleted_" + i);
        }

        PlayerPrefs.Save();
        RefreshTrophies();
    }

    private void LoadLevel(int levelIndex)
    {
        MissionDemolition.SET_START_LEVEL(levelIndex);
        SceneManager.LoadScene("_Scene_0");
    }

    private void RefreshTrophies()
    {
        if (trophyIcons == null) return;

        for (int i = 0; i < trophyIcons.Length; i++)
        {
            if (trophyIcons[i] == null) continue;

            bool completed = PlayerPrefs.GetInt("LevelCompleted_" + i, 0) == 1;
            trophyIcons[i].SetActive(completed);
        }
    }
}
