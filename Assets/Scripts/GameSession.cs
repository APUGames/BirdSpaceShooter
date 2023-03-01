using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] private Canvas MainMenuUI;

    private void Update()
    {

        if (SessionHandler.gameStarted)
        {
            MainMenuUI.enabled = false;
        }

    }
    public void ReloadGame()
    {
        SessionHandler.gameStarted = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);


    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
