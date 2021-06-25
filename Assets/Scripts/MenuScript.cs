using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Button continueButton;

    public void OnButtonClick_ContinueGame()
    {
        GameManager.Instance.ContinueGame();
    }

    public void OnButtonClick_StartGame()
    {
        GameManager.Instance.StartNewGame();
    }

    public void OnButtonClick_ExitGame()
    {
        GameManager.Instance.ExitGame();
    }

    public void OnButtonClick_OpenOptions()
    {
        
    }

    private void Start()
    {
        continueButton.gameObject.SetActive(GameSaveManager.CurrentSave.Levels.Count != 0);
    }
}
