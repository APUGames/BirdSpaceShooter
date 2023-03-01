using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] private Canvas mainMenuUI;

    private void Update()
    {

        if (SessionHandler.gameStarted)
        {
            mainMenuUI.enabled = false;
        }

    }
    public void ReloadGame()
    {
        SessionHandler.gameStarted = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //PlayerCollisions.stopCam = false;
        Time.timeScale = 1.0f;
        //SceneManager.LoadMainScene(0);


    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
