using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dates : MonoBehaviour
{
    private Rigidbody rigidBodyComponent;
    private GameObject plane;
    private Transform planeTransform;

    private float speed;
    private float planeLength;
   
    private TextMeshProUGUI textInput;

    public Color colorIni = Color.white;
    public Color colorFin = Color.green;
    public float duration = 1000f;
    Color lerpedColor = Color.white;
    private float t = 0;
    private bool flag;
    private Renderer rend;
    private float distanceTravelled = 0f;
    private Vector3 lastPosition;


    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        plane = GameObject.Find("Plane");

        planeLength = plane.GetComponent<MeshRenderer>().bounds.size.x;
        //Debug.Log(planeLength);
        
        speed = (float)plane.GetComponent<Plane>().speed;
        // Debug.Log(plane.GetComponent<Plane>().speed);
        //Debug.Log(speed);

        rend = GetComponent<Renderer>();
        lastPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);


        lerpedColor = Color.Lerp(colorIni, colorFin, t);
        rend.material.color = lerpedColor;
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        t = distanceTravelled / planeLength;

    }
    private void FixedUpdate()
    {
            
    }
}
