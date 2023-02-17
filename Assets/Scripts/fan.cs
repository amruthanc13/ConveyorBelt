using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, speed * Time.deltaTime);
    }

    public void AdjustFanSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
