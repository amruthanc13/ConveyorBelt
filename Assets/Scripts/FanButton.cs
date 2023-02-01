using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanButton : MonoBehaviour
{
    public GameObject fanLeft;
    public GameObject fanRight;
    public float rotateSpeed = 100;
    bool rotateStatus = false;

    public void RotateObject()
    {
        if(rotateStatus == true)
        {
            rotateStatus = false;
        }
        else {
            rotateStatus = true;
        }
    }

    void Update()
    {
        if(rotateStatus == true)
        {
            fanLeft.transform.Rotate(0,0, rotateSpeed * Time.deltaTime);
            fanRight.transform.Rotate(0,0, rotateSpeed * Time.deltaTime);
        }
    }
}
