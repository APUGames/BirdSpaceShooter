using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SessionHandler : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;

    public static bool gameStarted = false;
    public static bool gameOver = false;

    public PlayerController playerController;
    public LaserController laserController;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        if (!gameStarted)
        {
            ProcessCommon();
        }


    }

    void Update()
    {
        if (gameStarted && gameOver)
        {
            ProcessEnd();
            gameStarted = false;
            gameOver = false;
        }
    }

    public void ProcessCommon()
    {

        //pause game (stop time)
        Time.timeScale = 0;
        //dissallow mouse movement
        Cursor.lockState = CursorLockMode.None;
        //make cursor visible
        Cursor.visible = true;
        DetectCollisions.stopCam = true;
       
    }


    private void ProcessEnd()
    {
        gameOverUI.SetActive(true);
        ProcessCommon();

        /*
        if (playerController.GetHealth() == 0)// checking the health int
        {
            gameOverUI.SetActive(true);
            ProcessCommon();
        }
        */

    }
    

}
