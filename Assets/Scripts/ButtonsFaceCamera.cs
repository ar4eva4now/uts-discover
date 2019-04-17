using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsFaceCamera : MonoBehaviour
{
    public Camera main_camera;

    void Update()
    {
        transform.LookAt(transform.position + main_camera.transform.rotation * Vector3.forward, 
                        main_camera.transform.rotation * Vector3.up);
    }
}
