using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyor_plane : MonoBehaviour
{
    public float speed = 0.03f;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.mainTexture.wrapMode = TextureWrapMode.Repeat;
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Time.time * speed;
        rend.material.mainTextureOffset = new Vector2(0, offsetX);
    }
}
