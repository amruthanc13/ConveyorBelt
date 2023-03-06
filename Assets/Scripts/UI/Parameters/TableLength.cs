using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableLength : MonoBehaviour
{
    ToggleGroup toggleGroup;
    private GameObject table;
    private Transform tableTransform;
    // Start is called before the first frame update
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
        table = GameObject.Find("table");
        tableTransform = table.GetComponent<Transform>();
        length1ButtonClick();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void length1ButtonClick()
    {

        tableTransform.localScale = new Vector3(3.6f, 3f, 6f);
        tableTransform.position = new Vector3(30.5f,9.6f,22.3f);
        GameObject.Find("fan_case_left").transform.position = new Vector3(-17.95f, 11.33f, 13.64f);
        GameObject.Find("fan_case_right").transform.position = new Vector3(39.71f, 11.40f, 24.05f);
        GameObject.Find("capsule").transform.position = new Vector3(16.31f, 11.23f, -29.40f);
        GameObject.Find("bin").transform.position = new Vector3(33.77f, 8.71f, 22.08f);
        GameObject.Find("feeder").transform.position = new Vector3(-14.84f, 16.84f, 22.20f);
        GameObject.Find("DateSpawner").transform.position = new Vector3(-12.54f, 14.50f, 18.89f);

        GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().multiplier =6;

    }
    public void length2ButtonClick()
    {
        tableTransform.localScale = new Vector3(3.6f, 3f, 10f);
        tableTransform.position = new Vector3(30.5f, 9.6f, 22.3f);
        GameObject.Find("fan_case_left").transform.position = new Vector3(-50.66f, 11.33f, 13.64f);
        GameObject.Find("fan_case_right").transform.position = new Vector3(44.26f, 11.40f, 24.05f);
        GameObject.Find("capsule").transform.position = new Vector3(1.12f, 11.23f, -40.40f);
        GameObject.Find("bin").transform.position = new Vector3(42.4f, 8.71f, 22.08f);
        GameObject.Find("feeder").transform.position = new Vector3(-47.74f, 16.84f, 22.20f);
        GameObject.Find("DateSpawner").transform.position = new Vector3(-44.63f, 12.30f, 18.89f);

        GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().multiplier = 10;


    }
    public void length3ButtonClick()
    {
        tableTransform.localScale = new Vector3(3.6f, 3f, 13f);
        tableTransform.position = new Vector3(43.3f, 9.6f, 22.3f);
        GameObject.Find("fan_case_left").transform.position = new Vector3(-65.01f, 11.33f, 13.64f);
        GameObject.Find("fan_case_right").transform.position = new Vector3(63.9f, 11.40f, 24.05f);
        GameObject.Find("capsule").transform.position = new Vector3(-5.84f, 11.23f, -47f);
        GameObject.Find("bin").transform.position = new Vector3(57.96f, 8.71f, 22.08f);
        GameObject.Find("feeder").transform.position = new Vector3(-61.9f, 16.84f, 22.20f);
        GameObject.Find("DateSpawner").transform.position = new Vector3(-59.60f, 12.35f, 18.89f);

        GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().multiplier = 13;

    }
}
