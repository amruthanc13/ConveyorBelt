using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirFlow : MonoBehaviour
{
    // Start is called before the first frame update
    ToggleGroup toggleGroup;
    [SerializeField] private Slider coCurrentSlider;
    [SerializeField] private Slider counterCurrentSlider;
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();
        counterCurrentSlider.enabled = false;
        counterCurrentSlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void coCurrentButtonClick()
    {
        counterCurrentSlider.enabled = false;
        counterCurrentSlider.value = 0;
        coCurrentSlider.enabled = true;
        coCurrentSlider.value = 100;
    }

    public void counterCurrentButtonClick()
    {
        counterCurrentSlider.enabled = true;
        counterCurrentSlider.value = 100;
        coCurrentSlider.value = 0;
        coCurrentSlider.enabled = false;
    }
}
