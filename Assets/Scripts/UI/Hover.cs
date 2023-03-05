using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public GameObject Image;
    public GameObject Tooltip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void onHoverButton()
    {
        Image.SetActive(false);
        Tooltip.SetActive(true);   
    }

    public void onLeavingButton()
    {
        Image.SetActive(true);
        Tooltip.SetActive(false);
    }
}
