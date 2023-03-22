using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoistureContent : MonoBehaviour
{
    ToggleGroup toggleGroup ;

    //public List<float> xoutList = new List<float>(new float[10]);
    public List<float> xoutList = new List<float>() { 4f, 3.83f, 3.67f, 3.5f, 3.33f, 3.16f, 3f, 2.83f, 2.67f, 2.5f };
    public float Ms = 120f;
    private float m = 10f;
    private float xin;
    private int tablelength = 18;
    private float requiredTableLength;
    // Start is called before the first frame update
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
        Button1Click();
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
            Debug.Log(index);
            index++;
        }
        for (int j = 0; j < xoutList.Count; j++)
        {
            Debug.Log(xoutList[j]);
        }
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
            Debug.Log(index);
            index++;
        }
        for (int j = 0; j < xoutList.Count; j++)
        {
            Debug.Log(xoutList[j]);
        }


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
            Debug.Log(index);
            index++;
        }
        for (int j = 0; j < xoutList.Count; j++)
        {
            Debug.Log(xoutList[j]);
        }

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
            Debug.Log(index);
            index++;
        }
        for (int j = 0; j < xoutList.Count; j++)
        {
            Debug.Log(xoutList[j]);
        }

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
            Debug.Log(index);
            index++;
        }
        for (int j = 0; j < xoutList.Count; j++)
        {
            Debug.Log(xoutList[j]);
        }

    }
}
