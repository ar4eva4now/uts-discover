using UnityEngine;

/**
 * A class to help manage the statistics component in AR space.
 */
public class StatsController : MonoBehaviour
{
    /**
     * A public function to toggle the gameObject's display.
     */
    public void ToggleDisplay()
    {
        // Hide or show the encapsulating object
        gameObject.SetActive(!gameObject.activeSelf);
    }
}