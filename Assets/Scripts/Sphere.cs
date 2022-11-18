using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sphere : MonoBehaviour
{
    private Rigidbody rigidBodyComponent;
    private GameObject plane;
    private Transform planeTransform;
    private Vector3 lastPosition;

    private float speed;
    private float planeLength;
    private float distanceTravelled = 0f;

    private float waterContent = 100;
    private TextMeshProUGUI textInput;


    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        plane = GameObject.Find("Plane");
        planeLength = plane.GetComponent<Transform>().localScale.x *2 ;
        speed = plane.GetComponent<Plane>().speed;
        lastPosition = transform.position;

        textInput = FindObjectOfType<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {

        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        waterContent = (planeLength - distanceTravelled)/ planeLength * 100;
        if (waterContent < 0)
        {
            waterContent = 0;
        }
        textInput.SetText("Water Content: " + (waterContent).ToString("0") + "%");


    }
    private void FixedUpdate()
    {
            transform.Translate(Vector3.right * speed);
    }
}
