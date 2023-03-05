using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;
    [SerializeField] private string unit = "";
    float val = 0f;
    private float multiplier;
   /* public static Dates[] dates;*/

    // Start is called before the first frame update
    void Start()
    {
/*        dates = FindObjectsOfType<Dates>();
*/
        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = (v/2).ToString("0") + unit;
        });

    }

    // Update is called once per frame
    void Update()
    {
        
        val = _slider.value / 2;
        switch (_slider.value)
        {

            case 1:
            case 3:
                _sliderText.text = val.ToString("0.0") + unit;
                break;
            case 2:
            case 4:
                _sliderText.text = val.ToString("0") + unit;
                break;
            default:
                break;
        }
    }

    public void speedSliderOnValueChanged(float value)
    {
        /*dates = FindObjectsOfType<Dates>();
        Debug.Log(dates.Length);*/
        switch (value)
        {

            case 1:
                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed = 0.1f;

                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime = 0.10f;
                break;
            case 2:
                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed = 0.2f;

                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime = 0.08f;
                break;
            case 3:
                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed = 0.3f;

                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime = 0.20f;
                break;
            case 4:
                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().speed = 0.4f;

                GameObject.Find("conveyor_plane").GetComponent<conveyor_plane>().repeatTime = 0.04f;
                break;
            default:
                break;
        }
    }
}