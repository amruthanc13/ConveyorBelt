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
    public GameObject ParamCanvas;
    // public GameObject lessButton;
    private bool more = false;
    private bool graph = false;
    private bool param = false;

    // Start is called before the first frame update
    void Start()
    {
        more = false;
        graph = true;
        param = true;
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
        if(!graph)
        {
            GraphCanvas.SetActive(false);
            graph = true;
        }
        else{
            GraphCanvas.SetActive(true);
            graph = false;
        }
    }
    public void onParamsButtonClick()
    {
        if (!param)
        {
            ParamCanvas.SetActive(false);
            param = true;
        }
        else
        {
            ParamCanvas.SetActive(true);
            param = false;
        }
    }
}