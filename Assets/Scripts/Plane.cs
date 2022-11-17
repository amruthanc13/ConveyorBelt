using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public float scrollSpeedX = 0.1f;
    Renderer rend;
    private GameObject cylinder1;
    private GameObject cylinder2;
    private GameObject plane2;
    private Transform cylinder1Transform;
    private Transform cylinder2Transform;
    private Renderer plane2Renderer;

    // Start is called before the first frame update
    void Start()
    {
        cylinder1 = GameObject.Find("Cylinder1");
        cylinder1Transform = cylinder1.GetComponent<Transform>();
        cylinder2 = GameObject.Find("Cylinder2");
        cylinder2Transform = cylinder2.GetComponent<Transform>();
        plane2 = GameObject.Find("Plane2");

        rend = GetComponent<Renderer>();
        rend.material.mainTexture.wrapMode = TextureWrapMode.Repeat;

        plane2Renderer = plane2.GetComponent<Renderer>();
        plane2Renderer.material.mainTexture.wrapMode = TextureWrapMode.Repeat;

    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * scrollSpeedX;
        rend.material.mainTextureOffset = new Vector2(offsetX, 0);
        plane2Renderer.material.mainTextureOffset = new Vector2(-offsetX, 0);

        cylinder1Transform.Rotate(0, 0, -scrollSpeedX * Time.time);
        cylinder2Transform.Rotate(0, 0, -scrollSpeedX * Time.time);
    }
}
