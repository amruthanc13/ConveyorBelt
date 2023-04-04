using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class YoutGraph : MonoBehaviour
{
    public RectTransform GraphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;
    public GameObject Line;
    private LineRenderer lineRenderer;


    private void Awake()
    {
        GraphContainer = transform.Find("YOUTGraphContainer").GetComponent<RectTransform>();
        labelTemplateX = GraphContainer.Find("YOUTLabelX").GetComponent<RectTransform>();
        labelTemplateY = GraphContainer.Find("YOUTLabelY").GetComponent<RectTransform>();
        dashTemplateX = GraphContainer.Find("YOUTdashTemplateX").GetComponent<RectTransform>();
        dashTemplateY = GraphContainer.Find("YOUTdashTemplateY").GetComponent<RectTransform>();
        lineRenderer = Line.GetComponent<LineRenderer>();

        // List<int>  valueList = new List<int>() {5, 98, 56,45,30,22,17};
        //List<int>  valueList = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        List<float> valueList = new List<float>() { .038f, .04f, .042f, .044f, .046f, 0.048f, 0.05f, .052f, 0.054f,.056f };


        ShowGraph(valueList);
        // CreateCircle(new Vector2(200,200));
    }



    private void ShowGraph(List<float> valueList)
    {
        float xSize = 40f;
        float yMaximum = 100f;
        float graphHeight = GraphContainer.sizeDelta.y;
        float graphWidth = GraphContainer.sizeDelta.x;
        //GameObject lastCircleGameObject = null;
        for (int i = 0; i < valueList.Count; i++)
        {
            float xPosition = i * xSize;
            float yPosition = (valueList[i] / yMaximum) * 1000 * graphHeight;
            lineRenderer.SetPosition(i, new Vector3(xPosition, yPosition, 0));

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(GraphContainer, false);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition, -2f);
            labelX.GetComponent<TextMeshProUGUI>().text = (i * 2).ToString();

            RectTransform dashX = Instantiate(dashTemplateX);
            dashX.SetParent(GraphContainer, false);
            dashX.gameObject.SetActive(true);
            dashX.anchoredPosition = new Vector2(xPosition, 114.2f);
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
