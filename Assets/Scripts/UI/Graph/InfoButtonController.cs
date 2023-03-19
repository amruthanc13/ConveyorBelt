using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButtonController : MonoBehaviour
{
    public GameObject InfoCanvas;
    public GameObject GraphCanvas;
    public GameObject EquationsCanvas;
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
            GraphCanvas.SetActive(true);
            EquationsCanvas.SetActive(false);
            info = true;
        }
        else{
            InfoCanvas.SetActive(true);
            GraphCanvas.SetActive(false);
            EquationsCanvas.SetActive(false);
            info = false;
        }
    }
}
