using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameMode
{
    idle,
    playing,
    levelEnd
}
public class MissionDemolition : MonoBehaviour
{
    static private MissionDemolition S;
    static private int startLevel = 0;

    [Header("Inscribed")]
    public Text uitLevel;
    public Text uitShots;
    public Vector3 castlePos;
    public GameObject[] castles;

    [Header("Dynamic")]
    public int level;
    public int levelMax;
    public int shotsTaken;
    public GameObject castle;
    public GameMode mode = GameMode.idle;
    public string showing = "Show Slingshot";

    // reference to the UI panel shown when the player beats the final level
    public GameObject winScreen;

    void Start()
    {
        S = this;

        levelMax = castles.Length;
        level = Mathf.Clamp(startLevel, 0, levelMax - 1);
        shotsTaken = 0;
        StartLevel();
    }

    void StartLevel()
    {
        // hide win screen each time a level starts
        if (winScreen != null)
        {
            winScreen.SetActive(false);
        }

        if (castle != null)
        {
            Destroy(castle);
        }

        Projectile.DESTROY_PROJECTILES();

        castle = Instantiate<GameObject>(castles[level]);
        castle.transform.position = castlePos;

        Goal.goalMet = false;

        UpdateGUI();

        mode = GameMode.playing;

        FollowCam.SWITCH_VIEW(FollowCam.eView.both);
    }

    void UpdateGUI()
    {
        int displayLevel = Mathf.Min(level + 1, levelMax);
        uitLevel.text = "Level: "+ displayLevel +" of "+levelMax;
        uitShots.text = "Shots Taken: "+shotsTaken;
    }

    void Update()
    {
        UpdateGUI();

        if ((mode == GameMode.playing) && Goal.goalMet)
        {
            mode=GameMode.levelEnd;
            MarkLevelCompleted(level);

            FollowCam.SWITCH_VIEW(FollowCam.eView.both);

            Invoke("NextLevel", 2f);
        }
    }

    void NextLevel()
    {
        level++;
        if (level >= levelMax)
        {
            // finished all levels – show win UI instead of wrapping around
            ShowWinScreen();
            return;
        }
        StartLevel();
    }

    // display the end‑of‑game panel and pause gameplay
    void ShowWinScreen()
    {
        if (winScreen != null)
        {
            winScreen.SetActive(true);
        }
        mode = GameMode.idle;
    }

    // hooked up to the two buttons on the win panel:
    public void OnWinMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void OnWinRestart()
    {
        // restart from first level
        level = 0;
        shotsTaken = 0;
        startLevel = 0;
        if (winScreen != null)
        {
            winScreen.SetActive(false);
        }
        StartLevel();
    }

    static public void SHOT_FIRED()
    {
        S.shotsTaken++;
    }

    static public GameObject GET_CASTLE()
    {
        return S.castle;
    }

    static public void SET_START_LEVEL(int levelIndex)
    {
        startLevel = Mathf.Max(0, levelIndex);
    }

    public void ReloadCurrentLevel()
    {
        CancelInvoke("NextLevel");
        mode = GameMode.playing;
        StartLevel();
    }

    void MarkLevelCompleted(int levelIndex)
    {
        PlayerPrefs.SetInt("LevelCompleted_" + levelIndex, 1);
        PlayerPrefs.Save();
    }

}