using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene((int)GameScenes.Level_1);
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
        Level_1,
        Level_2
    }
}
