using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationsButton : MonoBehaviour
{
    public GameObject equationsCanvas;
    public GameObject InfoCanvas;
    public GameObject GraphCanvas;

    private bool equationsFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        equationsFlag = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onGraphequationsFlagButtonClick()
    {
        if (!equationsFlag)
        {
            equationsCanvas.SetActive(false);
            GraphCanvas.SetActive(true);
            InfoCanvas.SetActive(false);
            equationsFlag = true;
        }
        else
        {
            equationsCanvas.SetActive(true);
            GraphCanvas.SetActive(false);
            InfoCanvas.SetActive(false);
            equationsFlag = false;
        }
    }
}
