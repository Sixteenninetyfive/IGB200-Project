using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, - rotationSpeed * Time.deltaTime, 0, Space.Self);
        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
        }
    }
}
