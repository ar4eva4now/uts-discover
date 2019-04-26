using UnityEngine;
using UnityEngine.UI;

/**
 * A class to help manage the help menu in the game overlay canvas.
 */
public class HelpController : MonoBehaviour
{
    // GameObject fields
    public Button helpButton;
    
    /**
     * A public function to toggle the gameObject's display and update
     * the UI appropriately.
     */
    public void ToggleDisplay()
    {
        // Hide or show the encapsulating gameObject
        var obj = gameObject;
        obj.SetActive(!obj.activeSelf);
        
        // Load the appropriate button sprite
        var filePath = obj.activeSelf ? "uts-discover-ui-exit" : "uts-discover-ui-help";
        var sp  = Resources.Load<Sprite>(filePath);
        
        // Apply the button sprite
        helpButton.GetComponent<Image>().sprite = sp;
    }
}
