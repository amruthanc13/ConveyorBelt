using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButtonController : MonoBehaviour
{
    public GameObject InfoCanvas;
    private bool info = false;

    // Start is called before the first frame update
    void Start()
    {
        info = true;
    }

    public void onGraphInfoButtonClick()
    {
        if(!info)
        {
            InfoCanvas.SetActive(false);
            info = true;
        }
        else{
            InfoCanvas.SetActive(true);
            info = false;
        }
    }
}
