using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerContent : MonoBehaviour
{
    ToggleGroup toggleGroup ;
    [SerializeField] private TextMeshProUGUI mgText;

    // Start is called before the first frame update
    void Start()
    {
        toggleGroup = GetComponent<ToggleGroup>();

        Button3MgClick();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button1MgClick()
    {
        mgText.text = "<b>20000kg/h</b>";
    }
    public void Button2MgClick()
    {
        mgText.text = "<b>15000kg/h</b>";
    }
    public void Button3MgClick()
    {
        mgText.text = "<b>10000kg/h</b>";
    }
    public void Button4MgClick()
    {
        mgText.text = "<b>5000kg/h</b>";

    }
}
