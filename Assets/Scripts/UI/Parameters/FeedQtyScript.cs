using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedQtyScript : MonoBehaviour
{
    ToggleGroup toggleGroup;
    private int requiredCount = 0;
    private int weight = 5;

    // Start is called before the first frame update
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
        qty1ButtonClick();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void qty1ButtonClick()
    {
        weight = 5;
        requiredCount = (int)(weight * 1000 / 8);
        GameObject.Find("DateSpawner").GetComponent<DateSpawner>().requiredCount = requiredCount;


    }
    public void qty2ButtonClick()
    {
        weight = 10;
        requiredCount = (int)(weight * 1000 / 8);
        GameObject.Find("DateSpawner").GetComponent<DateSpawner>().requiredCount = requiredCount;

    }
    public void qty3ButtonClick()
    {
        weight = 20;
        requiredCount = (int)(weight * 1000 / 8);
        GameObject.Find("DateSpawner").GetComponent<DateSpawner>().requiredCount = requiredCount;

    }
}
