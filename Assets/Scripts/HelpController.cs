using UnityEngine;
using UnityEngine.UI;

/**
 * A class to help manage the help menu in the game overlay canvas.
 */
public class HelpController : MonoBehaviour
{
    // GameObject fields
    public Button helpButton;
    
    // Symbol fields
    private static readonly int SlideIn = Animator.StringToHash("SlideIn");

    /**
     * A public function to toggle the gameObject's display and update
     * the UI appropriately.
     */
    public void ToggleOpen()
    {
        var animator = gameObject.GetComponent<Animator>();
        
        // Play the slide in animation if the component is accessible
        if (animator == null) return;
        var isSlideIn = animator.GetBool(SlideIn);
        animator.SetBool(SlideIn, !isSlideIn);
            
        // Load the appropriate button sprite
        var filePath = isSlideIn ? "uts-discover-ui-help" : "uts-discover-ui-exit";
        var sp  = Resources.Load<Sprite>(filePath);
            
        // Apply the button sprite
        helpButton.GetComponent<Image>().sprite = sp;
    }
}
