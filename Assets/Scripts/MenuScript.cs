using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
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
}
