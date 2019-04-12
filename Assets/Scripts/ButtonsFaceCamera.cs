using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsFaceCamera : MonoBehaviour
{
    public Camera main_camera;

    void Update()
    {
        Vector3 v = main_camera.transform.position - transform.position;

        v.x = v.z = 0.0f;
        transform.LookAt(main_camera.transform.position - v);
        transform.Rotate(0, 180, 0);
    }
}
