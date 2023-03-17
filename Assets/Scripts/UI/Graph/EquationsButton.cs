using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquationsButton : MonoBehaviour
{
    public GameObject equationsCanvas;
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
            equationsFlag = true;
        }
        else
        {
            equationsCanvas.SetActive(true);
            equationsFlag = false;
        }
    }
}
