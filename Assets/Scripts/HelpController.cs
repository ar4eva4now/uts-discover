using UnityEngine;
using UnityEngine.UI;

/**
 * A class to help manage the help menu in the game overlay canvas.
 */
public class HelpController : MonoBehaviour
{
    // GameObject fields
    private Button helpButton;
    private Canvas screenCanvas;

    // Symbol fields
    private static readonly int SlideIn = Animator.StringToHash("SlideIn");

    private void Start()
    {
        screenCanvas = GameObject.Find("GameOverlayCanvas").GetComponent<Canvas>();
        helpButton = GameObject.Find("Help Button").GetComponent<Button>();
    }

    /**
     * Adjust the size of the panel to suit the canvas size.
     */
    private void FixedUpdate()
    {
        Rect rootCanvasRect = screenCanvas.GetComponent<RectTransform>().rect; //Gets the Sizing of the RectTransform
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
        string filePath = isSlideIn ? "UI/uts-discover-ui-help" : "UI/uts-discover-ui-exit";
        Sprite sp  = Resources.Load<Sprite>(filePath);

        // Apply the button sprite
        helpButton.GetComponent<Image>().sprite = sp;
    }
}
