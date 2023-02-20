using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayController : MonoBehaviour
{
    private bool playing = false;
    public Image image;
    public Sprite playIcon;
    public Sprite pauseIcon;
    public GameObject refreshButton;

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
            refreshButton.SetActive(true);
        }
        else
        {
            //Pause block
            image.sprite = playIcon;
            Time.timeScale = 0;
            playing = true;
            refreshButton.SetActive(true);
        }
    }

    public void refeshProcess()
    {
        SceneManager.LoadScene("Process");
    }
}
