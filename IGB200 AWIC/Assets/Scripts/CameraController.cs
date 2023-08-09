using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            transform.position += new Vector3(Time.deltaTime, 0, 0);
        }
    }
}
