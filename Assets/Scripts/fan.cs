using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    [SerializeField] private float speed ;
    // Start is called before the first frame update
    void Start()
    {
        speed = 500;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, -speed * Time.deltaTime);
    }
}
