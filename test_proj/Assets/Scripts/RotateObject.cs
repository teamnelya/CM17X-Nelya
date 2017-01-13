using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    public Camera mainCamera;
    public float zoomSpeed = .15F;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, mainCamera.transform.position));

        if (Input.GetMouseButton(0))
        {
            float h = -1 * horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(v, h, 0, Space.World);
        }
        if (Input.GetMouseButton(1))
        {
            float step = zoomSpeed * Input.GetAxis("Mouse Y");
            transform.position = transform.position + mainCamera.transform.forward * step;
        }
    }
}
