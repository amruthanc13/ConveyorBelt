using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreController : MonoBehaviour
{
    public Image image;
    public Sprite LessIcon;
    public Sprite MoreIcon;
    public GameObject GraphButton;
    public GameObject ParamsButton;
    public GameObject moreButton;
    public GameObject GraphCanvas;
    public GameObject GraphContainer;
    public GameObject YOUTGraphContainer;
    public GameObject ParamCanvas;
    public GameObject InfoCanvas;
    public GameObject onboardingCanvas;
    // public GameObject lessButton;
    private bool more = false;

    // Start is called before the first frame update
    void Start()
    {
        more = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onMoreButtonClick()
    {
        if(!more)
        {
            image.sprite = LessIcon;
            GraphButton.SetActive(true);
            ParamsButton.SetActive(true);
            more = true;
        }
        else{
            image.sprite = MoreIcon;
            GraphButton.SetActive(false);
            ParamsButton.SetActive(false);
            more = false;
            }
        
    }

    public void onGraphButtonClick()
    {

        if (GraphCanvas.transform.position.x == 4f)
        {
            //GraphCanvas.SetActive(false);
            
            GraphCanvas.transform.position = new Vector3(-96f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            GraphContainer.transform.position = new Vector3(-98.24f, GraphContainer.transform.position.y, GraphContainer.transform.position.z);
            YOUTGraphContainer.transform.position = new Vector3(-93.25f, YOUTGraphContainer.transform.position.y, YOUTGraphContainer.transform.position.z);
            PlayerPrefs.SetInt("graphTab", 0);
        }
        else{
            //GraphCanvas.SetActive(true);
            GraphCanvas.transform.position = new Vector3(4f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            GraphContainer.transform.position = new Vector3(1.76f, GraphContainer.transform.position.y, GraphContainer.transform.position.z);
            YOUTGraphContainer.transform.position = new Vector3(6.60f, YOUTGraphContainer.transform.position.y, YOUTGraphContainer.transform.position.z);
            InfoCanvas.SetActive(false);
            PlayerPrefs.SetInt("graphTab", 1);
        }
    }
    public void onParamsButtonClick()
    {

        if (ParamCanvas.activeSelf)
        {
            ParamCanvas.SetActive(false);
            PlayerPrefs.SetInt("paramTab", 0);
        }
        else
        {
            ParamCanvas.SetActive(true);
            PlayerPrefs.SetInt("paramTab", 1);
        }
    }

    public void onHelpButtonClick()
    {

        if (onboardingCanvas.activeSelf)
        {
            Debug.Log(onboardingCanvas.activeSelf);
            onboardingCanvas.SetActive(false);
        }
        else
        {
            Debug.Log(onboardingCanvas.activeSelf);
            onboardingCanvas.SetActive(true);
        }
    }

}
