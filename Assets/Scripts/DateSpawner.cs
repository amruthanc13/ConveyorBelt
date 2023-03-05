using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DateSpawner : MonoBehaviour
{

    public GameObject datePrefab;
    private int spawnCount = 0;
    private int requiredCount = 0;
    public float repeatTime = 0f;
    [SerializeField] private Slider _slider;
    // Start is called before the first frame update
    void Start()
    {
        repeatTime = (float)GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime;
        calculateNoOfDates(_slider.value);

        InvokeRepeating("spawnDates", 1f, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        repeatTime = (float)GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime;
        if (spawnCount >= requiredCount)
            CancelInvoke("spawnDates");
    }

    void spawnDates()
    //Vector3 pos = new Vector3()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, UnityEngine.Random.Range(transform.position.z - 2, transform.position.z + 2));
        Instantiate(datePrefab, pos, Quaternion.identity);
        spawnCount++;
    }

    public void calculateNoOfDates(float weight)
    {
        //Assuming weight of a fresh date is 8g
        requiredCount = (int)(Math.Round(weight, 0) * 1000 / 8);

    }
}
