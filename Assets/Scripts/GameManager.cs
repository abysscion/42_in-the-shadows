using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int _currentLevelID;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene((int)GameScenes.Map);
    }

    public void LoadLevel(int index)
    {
        _currentLevelID = (int)GameScenes.Menu + index;
        SceneManager.LoadScene(_currentLevelID);
    }

    public void CompleteLevel()
    {
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
