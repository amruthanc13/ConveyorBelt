using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heater : MonoBehaviour
{
    private Renderer rend;
    private Color colorIni = Color.white;
    public Color colorFin = Color.red;
    private Color lerpedColor = Color.white;
    private float duration = 20f;
    private float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lerpedColor = Color.Lerp(colorIni, colorFin, t);
        rend.material.color = lerpedColor;

        if (t < 1)
        {
            t += Time.deltaTime / duration;
        }
    }
}
