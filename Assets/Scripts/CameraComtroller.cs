using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComtroller : MonoBehaviour
{

    public float rotateSpeed = 10.0f, Speed = 10.0f, zoomSpeed = 10.0f;

    private void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        //float rotate = 0f;
        //if (Input.GetKey(KeyCode.Q))
        //    rotate = -1f;
        //else if (Input.GetKey(KeyCode.E))
        //    rotate = 1f;
        //transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * rotate, Space.World);
        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime * Speed, Space.Self);

        transform.position += transform.up * zoomSpeed  * Input.GetAxis("Mouse ScrollWheel");

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -30f, 10f), Mathf.Clamp(transform.position.y, -20f, 10f), Mathf.Clamp(transform.position.z, -20f, -40f));
    }

}
