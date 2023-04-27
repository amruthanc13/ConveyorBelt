using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayController : MonoBehaviour
{
    private bool playing = false;
    public Image image;
    public Sprite playIcon;
    public Sprite pauseIcon;
    public GameObject refreshButton;
    public GameObject ParamCanvas;
    public GameObject GraphCanvas;
    public GameObject onboarding;
    public TMP_Text toolTip;

    void Start()
    {
        playing = true;
        Time.timeScale = 0;
        ParamCanvas.GetComponent<CanvasGroup>().interactable = true;
        onboarding = GameObject.Find("Onboarding");

        int refresh = PlayerPrefs.GetInt("refreshed", 0);
        int paramTab = PlayerPrefs.GetInt("paramTab", 0);
        int graphTab = PlayerPrefs.GetInt("graphTab", 0);

        if (refresh == 1) 
        {
            //If the scene is refreshed, then do not show intro
            onboarding.SetActive(false);
            if (paramTab == 1)
            {
                ParamCanvas.SetActive(true);
            }
            else
            {
                ParamCanvas.SetActive(false);
            }

            if (graphTab == 1)
            {
                GraphCanvas.transform.position = new Vector3(4f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            }
            else
            {
                GraphCanvas.transform.position = new Vector3(-96f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            }
        }
        else
        {
            //If the scene is loaded from home page, then show intro
            onboarding.SetActive(true);
        }
    }

    public void playProcess()
    {

        if (playing)
        {
            //Play block
            image.sprite = pauseIcon;
            toolTip.text = "Pause";
            Time.timeScale = 1;
            playing = false;
            refreshButton.SetActive(true);
            ParamCanvas.GetComponent<CanvasGroup>().interactable = false;
        }
        else
        {
            //Pause block
            image.sprite = playIcon;
            toolTip.text = "Play";
            Time.timeScale = 0;
            playing = true;
            refreshButton.SetActive(true);
            ParamCanvas.GetComponent<CanvasGroup>().interactable = false;
        }
    }

    public void refeshProcess()
    {
        int refresh = 1;
        SceneManager.LoadScene("Process");
        PlayerPrefs.SetInt("refreshed", refresh); 
        PlayerPrefs.Save();

    }
}
