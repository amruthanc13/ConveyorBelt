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
            EquationsCanvas.SetActive(false);
            GraphCanvas.transform.position = new Vector3(5.16f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            info = true;
        }
        else{
            InfoCanvas.SetActive(true);
            EquationsCanvas.SetActive(false);
            GraphCanvas.transform.position = new Vector3(105.16f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            info = false;
        }
    }
}
