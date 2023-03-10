using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] private GameObject MainMenuUI;

    private void Update()
    {

        if (SessionHandler.gameStarted)
        {
            //Debug.Log("set main menu to false");
            MainMenuUI.SetActive(false);
        }

    }
    public void ReloadGame()//see if this needs be updated for clarification
    {
        //SceneManager.LoadScene("MainScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SessionHandler.gameStarted = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1.0f;
    }
}
