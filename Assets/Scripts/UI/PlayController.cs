using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    private bool playing = false;

    // public void pauseProcess()
    // {
    //     if(paused)
    //     {
    //         Time.timeScale = 1;
    //         paused = false;
    //     }
    //     else
    //     {
    //         Time.timeScale = 0;
    //         paused = true;
    //     }
    // }

     public void playProcess()
    {
        if(!playing)
        {
            Time.timeScale = 1;
            playing = false;
        }
        else
        {
            Time.timeScale = 0;
            playing = true;
        }
    }
}
