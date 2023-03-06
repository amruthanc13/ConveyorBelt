using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dates : MonoBehaviour
{
    private Rigidbody rigidBodyComponent;
    private GameObject plane;
    private Transform planeTransform;

    public float speed;
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
    private Vector3 startScale;
    private Vector3 targetScale;
    Material targetMat;
    public int multiplier;


    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
        plane = GameObject.Find("conveyor_plane");

        planeLength = plane.GetComponent<MeshRenderer>().bounds.size.x;
        
        speed = (float)plane.GetComponent<conveyor_plane>().speed;
        multiplier = plane.GetComponent<conveyor_plane>().multiplier;

        rend = GetComponent<Renderer>();
        lastPosition = transform.position;

        startScale = transform.localScale;
        targetScale = startScale * 0.75f;

        targetMat = Resources.Load("dates_texture", typeof(Material)) as Material;


    }

    // Update is called once per frame
    void Update()
    {
        speed = (float)plane.GetComponent<conveyor_plane>().speed;
        multiplier = plane.GetComponent<conveyor_plane>().multiplier;
        if (transform.position.y > 2) //TODO: needs to be changed
        {
            transform.Translate(Vector3.right * (speed) * multiplier * Time.deltaTime, Space.World);

            lerpedColor = Color.Lerp(colorIni, colorFin, t);

            transform.localScale = Vector3.Lerp(startScale, targetScale, t);

            rend.material.color = lerpedColor;


            distanceTravelled += Vector3.Distance(transform.position, lastPosition);
            lastPosition = transform.position;
            t = distanceTravelled / planeLength;

        }
    }
    private void FixedUpdate()
    {
            
    }
}
