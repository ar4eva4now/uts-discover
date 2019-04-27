using UnityEngine;

/**
 * A class to help manage the display of gameObjects.
 */
public class DisplayController : MonoBehaviour
{
    /**
     * A public function to toggle the gameObject's display.
     */
    public void Toggle()
    {
        // Hide or show the encapsulating object
        gameObject.SetActive(!gameObject.activeSelf);
    }
}