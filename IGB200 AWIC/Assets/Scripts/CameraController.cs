using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private int rotationDirection = 0;

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            rotationDirection = -1;
        }
        else if (Input.GetKey("d"))
        {
            rotationDirection = 1;
        }

        if (transform.rotation.y < -0.5f)
        {
            rotationDirection = 0;
        }

        if (rotationDirection == -1)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
        else if (rotationDirection == 1)
        {
            transform.Rotate(-rotationSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
