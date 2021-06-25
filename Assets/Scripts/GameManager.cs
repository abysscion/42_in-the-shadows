using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public LevelSettings CurrentLevel { get; private set; }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene((int)GameScenes.Map);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene((int)GameScenes.Map);
    }

    public void LoadLevel(LevelSettings level)
    {
        CurrentLevel = level;
        SceneManager.LoadScene((int)GameScenes.Menu + level.id);
    }

    public void CompleteLevel(LevelProgressionData data)
    {
        GameSaveManager.CurrentSave.AddOrReplaceLevelProgressionData(data);
        GameSaveManager.Save();
        SceneManager.LoadScene((int)GameScenes.Map);
    }

    private void Awake()
    {
        Instance = Instance ? Instance : this;
        Application.targetFrameRate = 60;
        SceneManager.LoadScene((int)GameScenes.Menu);
    }

    public enum GameScenes
    {
        DDOL,
        Map,
        Menu,
    }
}
