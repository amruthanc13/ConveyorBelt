using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = Rigidbody.position;
        Rigidbody.position += Vector3.back * 100.0f * Time.deltaTime;
        Rigidbody.MovePosition(position);


    }
}
