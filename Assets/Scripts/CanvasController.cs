﻿using UnityEngine;

/**
 * A class to manage the button canvas.
 */
public class CanvasController : MonoBehaviour
{
    // GameObject fields
    public Camera mainCamera;

    private void Update()
    {
        // Make the buttons face the camera
        var cameraRotation = mainCamera.transform.rotation;
        transform.LookAt(transform.position + cameraRotation * Vector3.forward, 
            cameraRotation * Vector3.up);
    }

}