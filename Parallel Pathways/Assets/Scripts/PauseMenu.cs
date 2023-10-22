using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel; 
   /* float previousTimeScale = 1;
    public Text pauseLabel;

    public static bool isPaused;*/

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }*/
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        /*
        if (Time.timeScale > 0)
        {
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0;
            AudioListener.pause = true;
            pauseLabel.enabled = true;

            isPaused = true;

        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = previousTimeScale;
            AudioListener.pause = false;
            pauseLabel.enabled = false;

            isPaused = false;

        }*/
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
