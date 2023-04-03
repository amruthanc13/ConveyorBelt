using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onboarding : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;
    public GameObject ParamCanvas;
    public GameObject GraphCanvas;
    public GameObject GraphContainer;
    public GameObject onBoardingCanvas;
    public GameObject InfoCanvas;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Panel1forwardClick()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    public void Panel2BackClick()
    {

        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void Panel2forwardClick()
    {

        panel2.SetActive(false);
        panel3.SetActive(true);
        ParamCanvas.SetActive(true);

    }
    public void Panel3BackClick()
    {

        panel2.SetActive(true);
        panel3.SetActive(false);
        ParamCanvas.SetActive(false);

    }

    public void Panel3forwardClick()
    {

        ParamCanvas.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(true);
        GraphCanvas.transform.position = new Vector3(4f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
        GraphContainer.transform.position = new Vector3(2.75f, GraphContainer.transform.position.y, GraphContainer.transform.position.z);
        InfoCanvas.SetActive(false);

    }
    public void Panel4BackClick()
    {

        panel3.SetActive(true);
        panel4.SetActive(false);
        ParamCanvas.SetActive(true);
        GraphCanvas.transform.position = new Vector3(-96f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
        GraphContainer.transform.position = new Vector3(102.75f, GraphContainer.transform.position.y, GraphContainer.transform.position.z);


    }
    public void Panel4forwardClick()
    {

        panel5.SetActive(true);
        panel4.SetActive(false);
        GraphCanvas.transform.position = new Vector3(-96f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
        GraphContainer.transform.position = new Vector3(102.75f, GraphContainer.transform.position.y, GraphContainer.transform.position.z);

    }

    public void Panel5BackClick()
    {

        panel4.SetActive(true);
        panel5.SetActive(false);
        GraphCanvas.transform.position = new Vector3(4f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
        GraphContainer.transform.position = new Vector3(2.75f, GraphContainer.transform.position.y, GraphContainer.transform.position.z);
        InfoCanvas.SetActive(false);
    }
    public void Panel5forwardClick()
    {

        panel6.SetActive(true);
        panel5.SetActive(false);

    }
    public void Panel6BackClick()
    {

        panel5.SetActive(true);
        panel6.SetActive(false);

    }
    public void exitClick()
    {

        onBoardingCanvas.SetActive(false);
        GraphCanvas.transform.position = new Vector3(-96f, GraphCanvas.transform.position.y, GraphCanvas.transform.position.z);
        ParamCanvas.SetActive(false);
    }
}
