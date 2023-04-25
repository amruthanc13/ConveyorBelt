using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class DateSpawner : MonoBehaviour
{

    public GameObject datePrefab;
    public float repeatTime = 0f;
    public float repeatTimeOld = 0f;
    // Start is called before the first frame update
    void Start()
    {
        repeatTime = (float)GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime;

        InvokeRepeating("spawnDates", 1f, repeatTime);
        repeatTimeOld = repeatTime;
    }

    // Update is called once per frame
    void Update()
    {
        repeatTime = (float)GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime;

        if (repeatTimeOld != repeatTime)
        {
            CancelInvoke("spawnDates");

            InvokeRepeating("spawnDates", 0f, repeatTime);
            repeatTimeOld = repeatTime;
        }
        

    }

    void spawnDates()
    //Vector3 pos = new Vector3()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, UnityEngine.Random.Range(transform.position.z - 2, transform.position.z + 2));
        GameObject cloneDates =Instantiate(datePrefab, pos, Quaternion.identity);
        if(GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed == 0.1f) {
            Destroy(cloneDates, 100);
        } else if(GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed == 0.2f) {
            Debug.Log("speed is 1");
            Destroy(cloneDates, 60);
        } else if(GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed == 0.3f) {
            Destroy(cloneDates, 50);
        } else if(GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed == 0.4f) {
            Destroy(cloneDates, 40);
        }
        // Destroy(cloneDates, 20);
    }


}
