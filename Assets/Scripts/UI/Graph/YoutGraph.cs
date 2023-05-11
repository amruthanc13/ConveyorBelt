using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class YoutGraph : MonoBehaviour
{
    public RectTransform GraphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;
    public GameObject Line;
    public GameObject warning;
    private LineRenderer lineRenderer;

    public List<float> youtList = new List<float>() { .038f, .04f, .042f, .044f, .046f, 0.048f, 0.05f, .052f, 0.054f, .056f }; 


    public ToggleGroup powertoggleGroup;
    public string powertoggle = "power3";

    private void Awake()
    {
        GraphContainer = transform.Find("YOUTGraphContainer").GetComponent<RectTransform>();
        labelTemplateX = GraphContainer.Find("YOUTLabelX").GetComponent<RectTransform>();
        labelTemplateY = GraphContainer.Find("YOUTLabelY").GetComponent<RectTransform>();
        dashTemplateX = GraphContainer.Find("YOUTdashTemplateX").GetComponent<RectTransform>();
        dashTemplateY = GraphContainer.Find("YOUTdashTemplateY").GetComponent<RectTransform>();
        lineRenderer = Line.GetComponent<LineRenderer>();

        foreach (Toggle toggle in powertoggleGroup.GetComponentsInChildren<Toggle>())
        {
            toggle.onValueChanged.AddListener(delegate { OnToggleValueChanged(toggle); });
            toggle.onValueChanged.AddListener(delegate { calculateValues(); });
        }


      //  List<float> valueList = new List<float>() { .038f, .04f, .042f, .044f, .046f, 0.048f, 0.05f, .052f, 0.054f,.056f };


        ShowGraph(youtList);
        // CreateCircle(new Vector2(200,200));
    }

    public void OnToggleValueChanged(Toggle changedToggle)
    {
        // Do something with the changed toggle
        if (changedToggle.isOn)
        {
            //Debug.Log(changedToggle.name + " is now selected");
            powertoggle = changedToggle.name;
        }
        else
        {
            //Debug.Log(changedToggle.name + " is now deselected");
        }
    }

    public void calculateValues()
    {
        float ms = 120f;
        float mg = 10000f;
        float yin = 0.038f;
        List<float> xoutList = new List<float>() { 0f, .1667f, .333f, .5f, .666f, 0.833f, 1f, 1.1666f, 1.333f, 1.5f };

        switch (powertoggle)
        {
            case "power1":
                mg = 20000;
                warning.SetActive(false);
                break;
            case "power2":
                mg = 15000;
                warning.SetActive(false);
                break;
            case "power3":
                mg = 10000;
                warning.SetActive(false);
                break;
            case "power4":
                mg = 5000;
                warning.SetActive(true);
                break;
            default:
                mg = 10000;
                warning.SetActive(false);
                break;

        }
        //Debug.Log(mg);
        float yout = 0;
        for (int i = 0; i < 10; i++)
        {
            yout = ((ms / mg) * xoutList[i]) + yin;
            youtList[i] = yout;
            //Debug.Log(yout);
        }
        float yMaximum = 100f;
        float graphHeight = GraphContainer.sizeDelta.y;
        float graphWidth = GraphContainer.sizeDelta.x;
        float xSize = 40f;
        for (int i = 0; i < youtList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = ((youtList[i] / yMaximum) * 1000 * graphHeight) - 15f;
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));
            Line.GetComponent<LineAnimator>().linePoints[i] = new Vector3(xPosition, yPosition, 0);
            //Debug.Log(youtList[i]);
            //Debug.Log(xPosition+ " "+ yPosition);

        }
        Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
        Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];
    }
    private void ShowGraph(List<float> valueList)
    {
        float xSize = 40f;
        float yMaximum = 100f;
        float graphHeight = GraphContainer.sizeDelta.y;
        float graphWidth = GraphContainer.sizeDelta.x;

        for (int i = 0; i < valueList.Count; i++)
        {
           // Debug.Log("Value list inside showgraph***********************");
            //Debug.Log(valueList[i]);
            float xPosition = i * xSize;
            float yPosition = ((valueList[i] / yMaximum) * 1000 * graphHeight) -15f; 
          //  lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(GraphContainer, false);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition, -2.1f);
            labelX.GetComponent<TextMeshProUGUI>().text = (i * 2).ToString();

            RectTransform dashX = Instantiate(dashTemplateX);
            dashX.SetParent(GraphContainer, false);
            dashX.gameObject.SetActive(true);
            dashX.anchoredPosition = new Vector2(xPosition, 130.7f);
        }
       // Line.GetComponent<LineAnimator>().startPosition = Line.GetComponent<LineAnimator>().linePoints[0];
       // Line.GetComponent<LineAnimator>().endPosition = Line.GetComponent<LineAnimator>().linePoints[1];

        int separatorCount = 10;
        for (int i = 0; i <= separatorCount; i++)
        {
            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(GraphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / separatorCount;
            labelY.anchoredPosition = new Vector2(-5f, (normalizedValue * graphHeight) + 2f);
            labelY.GetComponent<TextMeshProUGUI>().text = (normalizedValue * yMaximum /1000).ToString();

            RectTransform dashY = Instantiate(dashTemplateY);
            dashY.SetParent(GraphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(1.199997f, normalizedValue * graphHeight);
        }

    }

}
