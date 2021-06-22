using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int _currentLevelIndex = 1;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene((int)GameScenes.Level_1);
    }

    public void CompleteLevel()
    {
        _currentLevelIndex++;
        var newSceneIndex = (int)GameScenes.Menu + _currentLevelIndex;
        if (newSceneIndex < SceneManager.sceneCountInBuildSettings)
            SceneManager.LoadScene(newSceneIndex);
        else
            SceneManager.LoadScene((int)GameScenes.Menu);
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
