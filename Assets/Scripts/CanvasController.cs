using UnityEngine;

/**
 * A class to manage the button canvas rotation.
 */
public class CanvasController : MonoBehaviour
{
    // GameObject fields
    private GameObject _mainCamera;

    private void Start()
    {
        _mainCamera = GameObject.Find("Camera");
    }
    private void Update()
    {
        // Make the canvas face the camera
        var cameraRotation = _mainCamera.transform.rotation;
        transform.LookAt(transform.position + cameraRotation * Vector3.forward, 
            cameraRotation * Vector3.up);
    }
}
