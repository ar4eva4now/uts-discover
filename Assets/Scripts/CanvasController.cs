using UnityEngine;

/**
 * A class to manage the button canvas rotation.
 */
public class CanvasController : MonoBehaviour
{
    // GameObject fields
    public Camera mainCamera;

    private void LateUpdate()
    {
        // Make the canvas face the camera
        var cameraRotation = mainCamera.transform.rotation;
        var frontVector = transform.position + cameraRotation * Vector3.forward;
        var upVector = cameraRotation * Vector3.up;
        
        transform.LookAt(frontVector, upVector);
    }
}
