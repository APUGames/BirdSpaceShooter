using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    //this scripst will manage the timer ui text
    public int startTime;

    private float currentTime;
    private float nextCurrentTime;
    private float intervalTime = 1.0f;
    private float baseIntervalTime = 0f;

    private Text timerText;

    private int trackTime;

    private bool isPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
        timerText.text = startTime.ToString();
        currentTime =(float) startTime;
        trackTime = startTime;
        //nextCurrentTime = currentTime - 1.0f;

    }

    // Update is called once per frame
    void Update()
    {
       if (isPlaying)
        {
            if (baseIntervalTime < intervalTime)
            {
                baseIntervalTime += Time.deltaTime;
            }
            else
            {
                currentTime -= intervalTime;
                trackTime = (int)currentTime;// conversion
                timerText.text = trackTime.ToString();
                baseIntervalTime = 0f;

            }
            //check if tracktime is = zero
            //if 0 themn player won
            if (trackTime == 0)
            {
                isPlaying = false;
                SessionHandler.gameOver = true;

            }// should stop at 0 by here                     
        }
        
    }
   

}
