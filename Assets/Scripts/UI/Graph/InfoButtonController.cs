using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButtonController : MonoBehaviour
{
    public GameObject InfoCanvas;
    public GameObject GraphCanvas;
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
            Debug.Log(GraphCanvas.transform.position);
            GraphCanvas.transform.position = new Vector3(2.75f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            info = true;
        }
        else{
            InfoCanvas.SetActive(true);
            GraphCanvas.transform.position = new Vector3(102.75f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
            info = false;
        }
    }
}
