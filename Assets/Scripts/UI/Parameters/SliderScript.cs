using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;
    [SerializeField] private string unit = "";
    [SerializeField] private string decimals = "0";
    // Start is called before the first frame update
    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = v.ToString(decimals) + unit ;
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        _sliderText.text = _slider.value.ToString(decimals) + unit;
    }
}
