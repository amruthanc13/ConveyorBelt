using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayController : MonoBehaviour
{
    private bool playing = false;
    public Image image;
    public Sprite playIcon;
    public Sprite pauseIcon;

    void Start()
    {
        playing = true;
        Time.timeScale = 0;
    }

    public void playProcess()
    {

        if (playing)
        {
            //Play block
            image.sprite = pauseIcon;
            Time.timeScale = 1;
            playing = false;
        }
        else
        {
            //Pause block
            image.sprite = playIcon;
            Time.timeScale = 0;
            playing = true;
        }
    }
}
