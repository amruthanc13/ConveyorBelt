using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoistureContent : MonoBehaviour
{
    ToggleGroup toggleGroup ;

    //public List<float> xoutList = new List<float>(new float[10]);
    public List<float> xoutList = new List<float>() { 4f, 3.83f, 3.67f, 3.5f, 3.33f, 3.16f, 3f, 2.83f, 2.67f, 2.5f };
    private float Ms = 120f;
    private float m = 10f;
    private float xin;
    private int tablelength = 18;
    private float length;
    private float requiredTableLength;
    public GameObject Line;
    public GameObject GraphCanvas;
    private GameObject plane;
    private LineRenderer lineRenderer;
    [SerializeField] private TextMeshProUGUI xinText;
    [SerializeField] private TextMeshProUGUI lengthText;

    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.Find("conveyor_plane");
        toggleGroup = GetComponent<ToggleGroup>();
        lineRenderer = Line.GetComponent<LineRenderer>();
        if (!GraphCanvas.activeSelf)
        {
            Line.GetComponent<LineAnimator>().startParallel();
        }

        Button3Click();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button1Click()
    {
        xinText.text = "<b>8 kg<sub><b>H<sub>2</sub>O</b></sub>/kg<sub><b>dr.s</b></sub></b>";
        
        xin = 8;
        int index = 0;
        float xout = 0;
        for (int i = 0; i <= tablelength; i += 2)
        {
            xout = ((i * -m * 1) / Ms) + xin;
            xoutList[index] = xout;
            index++;
        }

        float xSize = 40f;
        float yMaximum = 10f;
        float graphHeight = 259.99f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i  * xSize;
            float yPosition = ((xoutList[i] / yMaximum) * graphHeight) - 15f;
           
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];

        length = (float)(Ms * (1.5 - xin)) / (-m * 1);
        lengthText.text = length.ToString() + " m";

        plane.GetComponent<conveyor_plane>().distanceMultiplier = 4f;
    }
    public void Button2Click()
    {
        xinText.text = "<b>6 kg<sub><b>H<sub>2</sub>O</b></sub>/kg<sub><b>dr.s</b></sub></b>";
        xin = 6;
        int index = 0;
        float xout = 0;
        for (int i = 0; i <= tablelength; i += 2)
        {
            xout = ((i * -m * 1) / Ms) + xin;
            xoutList[index] = xout;
            index++;
        }

        float xSize = 40f;
        float yMaximum = 10f;
        float graphHeight = 259.99f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = ((xoutList[i] / yMaximum) * graphHeight) - 15f;
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];
        length = (float)(Ms * (1.5 - xin)) / (-m * 1);
        lengthText.text = length.ToString() + " m";

        plane.GetComponent<conveyor_plane>().distanceMultiplier = 4f;
    }
    public void Button3Click()
    {
        xinText.text = "<b>4 kg<sub><b>H<sub>2</sub>O</b></sub>/kg<sub><b>dr.s</b></sub></b>";
        xin = 4;
        int index = 0;
        float xout = 0;
        for (int i = 0; i <= tablelength; i += 2)
        {
            xout = ((i * -m * 1) / Ms) + xin;
            xoutList[index] = xout;
            index++;
        }

        float xSize = 40f;
        float yMaximum = 10f;
        float graphHeight = 259.99f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = ((xoutList[i] / yMaximum) * graphHeight) - 15f;
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);

        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];
        length = (float)(Ms * (1.5 - xin)) / (-m * 1);
        lengthText.text = length.ToString() + " m";

        plane.GetComponent<conveyor_plane>().distanceMultiplier = 2f;
    }
    public void Button4Click()
    {
        xinText.text = "<b>3 kg<sub><b>H<sub>2</sub>O</b></sub>/kg<sub><b>dr.s</b></sub></b>";
        xin = 3;
        int index = 0;
        float xout = 0;
        for (int i = 0; i <= tablelength; i += 2)
        {
            xout = ((i * -m * 1) / Ms) + xin;
            xoutList[index] = xout;
            index++;
        }

        float xSize = 40f;
        float yMaximum = 10f;
        float graphHeight = 259.99f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = ((xoutList[i] / yMaximum) * graphHeight) - 15f;
            Debug.Log("xposition :" + xPosition + "Y position " + yPosition);
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];
        length = (float)(Ms * (1.5 - xin)) / (-m * 1);
        lengthText.text = length.ToString() + " m";
        plane.GetComponent<conveyor_plane>().distanceMultiplier = 1.5f;

    }
    public void Button5Click()
    {
        xinText.text = "<b>2 kg<sub><b>H<sub>2</sub>O</b></sub>/kg<sub><b>dr.s</b></sub></b>";
        xin = 2;
        int index = 0;
        float xout = 0;
        for (int i = 0; i <= tablelength; i += 2)
        {
            xout = ((i * -m * 1) / Ms) + xin;
            xoutList[index] = xout;
            index++;
        }

        float xSize = 40f;
        float yMaximum = 10f;
        float graphHeight = 259.99f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = ((xoutList[i] / yMaximum) * graphHeight) - 15f;
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];
        length = (float)(Ms * (1.5 - xin)) / (-m * 1);
        lengthText.text = length.ToString()+ " m";
        plane.GetComponent<conveyor_plane>().distanceMultiplier = 0.4f;

    }

}
