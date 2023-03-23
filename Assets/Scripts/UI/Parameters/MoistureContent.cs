using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoistureContent : MonoBehaviour
{
    ToggleGroup toggleGroup ;

    //public List<float> xoutList = new List<float>(new float[10]);
    public List<float> xoutList = new List<float>() { 4f, 3.83f, 3.67f, 3.5f, 3.33f, 3.16f, 3f, 2.83f, 2.67f, 2.5f };
    private float Ms = 120f;
    private float m = 10f;
    private float xin;
    private int tablelength = 18;
    private float requiredTableLength;
    public GameObject Line;
    public GameObject GraphCanvas;
    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
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
        float yMaximum = 100f;
        float graphHeight = 230f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = (xoutList[i] / yMaximum) * 10 * graphHeight;
           
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];

    }
    public void Button2Click()
    {
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
        float yMaximum = 100f;
        float graphHeight = 230f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = (xoutList[i] / yMaximum) * 10 * graphHeight;
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];
    }
    public void Button3Click()
    {
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
        float yMaximum = 100f;
        float graphHeight = 230f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = (xoutList[i] / yMaximum) * 10 * graphHeight;
           // Debug.Log("xposition :" + xPosition + "Y position " + yPosition);
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];
    }
    public void Button4Click()
    {
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
        float yMaximum = 100f;
        float graphHeight = 230f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = (xoutList[i] / yMaximum) * 10 * graphHeight;
           // Debug.Log("xposition :" + xPosition + "Y position " + yPosition);
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];

    }
    public void Button5Click()
    {
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
        float yMaximum = 100f;
        float graphHeight = 230f;

        for (int i = 0; i < xoutList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = (xoutList[i] / yMaximum) * 10 * graphHeight;
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];

    }

}
