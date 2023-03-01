using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverUI;

    public static bool gameStarted = false;
    public static bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.enabled = false;
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


    void ProcessEnd()
    {
        gameOverUI.enabled = true;
        ProcessCommon();
    }
}
