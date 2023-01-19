using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;
    [SerializeField] float lookSpeed = 0.01f;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = transform.right * Input.GetAxis("Horizontal");
        velocity += transform.forward * Input.GetAxis("Vertical");
        rigidbody.velocity = Vector3.ClampMagnitude(velocity, 1) * moveSpeed;

        transform.Rotate(transform.up, Input.GetAxis("Mouse X") * Mathf.Rad2Deg * Time.deltaTime * lookSpeed);

        Camera.main.transform.Rotate(Vector3.right, -Input.GetAxis("Mouse Y") * Mathf.Rad2Deg * Time.deltaTime * lookSpeed);

        float angle = Camera.main.transform.eulerAngles.x;

        if (angle > 180)
            angle -= 360;
        if (angle < -180)
            angle += 360;
        angle = Mathf.Clamp(angle, -60f, 60f);
        Camera.main.transform.localEulerAngles = new Vector3(angle, 0, 0);
    }
}
