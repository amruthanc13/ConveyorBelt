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
    public GameObject ParamCanvas;

    void Start()
    {
        playing = true;
        Time.timeScale = 0;
        ParamCanvas.GetComponent<CanvasGroup>().interactable = true;
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
            ParamCanvas.GetComponent<CanvasGroup>().interactable = false;
        }
        else
        {
            //Pause block
            image.sprite = playIcon;
            Time.timeScale = 0;
            playing = true;
            refreshButton.SetActive(true);
            ParamCanvas.GetComponent<CanvasGroup>().interactable = false;
        }
    }

    public void refeshProcess()
    {
        SceneManager.LoadScene("Process");
    }
}
