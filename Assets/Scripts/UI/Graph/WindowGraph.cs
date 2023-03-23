using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
// using CodeMonkey.Utils;

public class WindowGraph : MonoBehaviour
{
    [SerializeField] private Sprite circleSprite;
    private RectTransform GraphContainer;
    private RectTransform labelTemplateX;
    private RectTransform labelTemplateY;
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;

    public ToggleGroup toggleGroup;

    private void Awake() {
        GraphContainer = transform.Find("GraphContainer").GetComponent<RectTransform>();
        labelTemplateX = GraphContainer.Find("LabelX").GetComponent<RectTransform>();
        labelTemplateY = GraphContainer.Find("LabelY").GetComponent<RectTransform>();
        dashTemplateX = GraphContainer.Find("dashTemplateX").GetComponent<RectTransform>();
        dashTemplateY = GraphContainer.Find("dashTemplateY").GetComponent<RectTransform>();

        // List<int>  valueList = new List<int>() {5, 98, 56,45,30,22,17};
        //List<int>  valueList = new List<int>() {1,2,3,4,5,6,7,8,9,10};
        // List<float> valueList = new List<float>() { 4f, 3.83f, 3.67f, 3.5f, 3.33f, 3.16f, 3f, 2.83f, 2.67f, 2.5f };

        List<float> valueList = toggleGroup.GetComponent<MoistureContent>().xoutList;

        ShowGraph(valueList);
        // CreateCircle(new Vector2(200,200));
    }

    private GameObject CreateCircle(Vector2 anchoredPosition) {
        GameObject gameObject = new GameObject("circle", typeof(Image));
        gameObject.transform.SetParent(GraphContainer, false);
        gameObject.GetComponent<Image>().sprite = circleSprite;
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = anchoredPosition;
        rectTransform.sizeDelta = new Vector2(11,11);
        rectTransform.anchorMin = new Vector2(0,0);
        rectTransform.anchorMax = new Vector2(0,0);
        return gameObject;
    }

    private void ShowGraph(List<float> valueList) {
        float xSize = 40f;
        float yMaximum = 100f;
        float graphHeight = GraphContainer.sizeDelta.y;
        float graphWidth = GraphContainer.sizeDelta.x;
        //GameObject lastCircleGameObject = null;
        for(int i = 0; i < valueList.Count; i++) {
            float xPosition = i * xSize;
            float yPosition = (valueList[i] / yMaximum) *10* graphHeight;
            //Debug.Log("xposition :"+xPosition +"Y position "+yPosition);
            /*GameObject circleGameObject = CreateCircle(new Vector2(xPosition,yPosition));
            if(lastCircleGameObject != null) {
                CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition, circleGameObject.GetComponent<RectTransform>().anchoredPosition);
            }
            lastCircleGameObject = circleGameObject;*/

            RectTransform labelX = Instantiate(labelTemplateX);
            labelX.SetParent(GraphContainer, false);
            labelX.gameObject.SetActive(true);
            labelX.anchoredPosition = new Vector2(xPosition, -2f);
            labelX.GetComponent<TextMeshProUGUI>().text = (i*2).ToString();

            RectTransform dashX = Instantiate(dashTemplateX);
            dashX.SetParent(GraphContainer, false);
            dashX.gameObject.SetActive(true);
            dashX.anchoredPosition = new Vector2(xPosition, 113.2f);
        }

        int separatorCount = 10;
        for(int i=0; i<=separatorCount; i++)
        {
            RectTransform labelY = Instantiate(labelTemplateY);
            labelY.SetParent(GraphContainer, false);
            labelY.gameObject.SetActive(true);
            float normalizedValue = i * 1f / separatorCount;
            labelY.anchoredPosition = new Vector2(-5f, (normalizedValue*graphHeight)+2f);
            labelY.GetComponent<TextMeshProUGUI>().text = (normalizedValue*yMaximum/10).ToString();

            RectTransform dashY = Instantiate(dashTemplateY);
            dashY.SetParent(GraphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(1.199997f, normalizedValue * graphHeight);
        }
    }

    private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB) {
        GameObject gameObject = new GameObject("dotConnection", typeof(Image));
        gameObject.transform.SetParent(GraphContainer, false);
        gameObject.GetComponent<Image>().color = new Color(1,1,1,.5f);
        RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
        Vector2 dir = (dotPositionB - dotPositionA).normalized;
        float distance = Vector2.Distance(dotPositionA, dotPositionB);
        rectTransform.anchorMin = new Vector2(0,0);
        rectTransform.anchorMax = new Vector2(0,0);
        rectTransform.sizeDelta = new Vector2(distance,3f);
        rectTransform.anchoredPosition = dotPositionA + dir * distance * .5f;
        // rectTransform.localEulerAngles = new Vector3(0,0, 90f);
        rectTransform.localEulerAngles = new Vector3(0,0, GetAngleFromVectorFloat(dir));
    }

    float GetAngleFromVectorFloat(Vector2 dir)
    {
        dir = dir.normalized;
        float n = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        if (n < 0) n += 360;
        return n;
    }

}
