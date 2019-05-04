using UnityEngine;
using UnityEngine.UI;

/**
 * A class to help manage the help menu in the game overlay canvas.
 */
public class HelpController : MonoBehaviour
{
    // GameObject fields
    public Button helpButton;
    public Canvas parent;

    // Symbol fields
    private static readonly int SlideIn = Animator.StringToHash("SlideIn");

    /**
     * Adjust the size of the panel to suit the canvas size.
     */
    private void Update()
    {
        Rect rootCanvasRect = parent.GetComponent<RectTransform>().rect; //Gets the Sizing of the RectTransform
        RectTransform panelRect = gameObject.GetComponent<RectTransform>(); // Gets the RectTransform (to manipulate the size of the panel);
        panelRect.sizeDelta = new Vector2(rootCanvasRect.width, rootCanvasRect.height); // Adjust the size of the panel
    }

    /**
     * A public function to toggle the gameObject's display and update
     * the UI appropriately.
     */
    public void ToggleOpen()
    {

        //Use proper datatypes for better memory management rather than vars. 
        Animator animator = gameObject.GetComponent<Animator>();

        // Play the slide in animation if the component is accessible
        if (animator == null) return;

        //Use proper datatypes for better memory management rather than vars.
        bool isSlideIn = animator.GetBool(SlideIn);
        animator.SetBool(SlideIn, !isSlideIn);

        // Load the appropriate button sprite
        string filePath = isSlideIn ? "uts-discover-ui-help" : "uts-discover-ui-exit";
        Sprite sp  = Resources.Load<Sprite>(filePath);

        // Apply the button sprite
        helpButton.GetComponent<Image>().sprite = sp;
    }

    //// GameObject fields
    //public Button helpButton;

    //// Symbol fields
    //private static readonly int SlideIn = Animator.StringToHash("SlideIn");

    ///**
    // * A public function to toggle the gameObject's display and update
    // * the UI appropriately.
    // */
    //public void ToggleOpen()
    //{
    //    var animator = gameObject.GetComponent<Animator>();

    //    // Play the slide in animation if the component is accessible
    //    if (animator == null) return;
    //    var isSlideIn = animator.GetBool(SlideIn);
    //    animator.SetBool(SlideIn, !isSlideIn);

    //    // Load the appropriate button sprite
    //    var filePath = isSlideIn ? "uts-discover-ui-help" : "uts-discover-ui-exit";
    //    var sp  = Resources.Load<Sprite>(filePath);

    //    // Apply the button sprite
    //    helpButton.GetComponent<Image>().sprite = sp;
    //}
}
