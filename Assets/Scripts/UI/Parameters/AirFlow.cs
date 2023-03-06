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
        counterCurrentSlider.interactable = false;
        counterCurrentSlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void coCurrentButtonClick()
    {
        counterCurrentSlider.interactable = false;
        counterCurrentSlider.value = 0;
        coCurrentSlider.interactable = true;
        coCurrentSlider.value = 100;
        GameObject.Find("heating_blocks_left").GetComponent<heater>().enabled = true;
        GameObject.Find("heating_blocks_right").GetComponent<heater>().enabled = false;

    }

    public void counterCurrentButtonClick()
    {
        counterCurrentSlider.interactable = true;
        counterCurrentSlider.value = 100;
        coCurrentSlider.value = 0;
        coCurrentSlider.interactable = false;
        GameObject.Find("heating_blocks_left").GetComponent<heater>().enabled = false;
        GameObject.Find("heating_blocks_right").GetComponent<heater>().enabled = true;
    }
}
