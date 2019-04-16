using UnityEngine;

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
        var cameraPos = mainCamera.transform.position;
        var v = cameraPos - transform.position;

        v.x = v.z = 0.0f;
        transform.LookAt(cameraPos - v);
        transform.Rotate(0, 180, 0);
    }
}
