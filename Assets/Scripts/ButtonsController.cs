using UnityEngine;
using UnityEngine.UI;

/**
 * A class to help manage button actions.
 */
public class ButtonsController : MonoBehaviour
{
    // GameObject fields
    public Button welcomeButton;
    public Button locationButton;
    public Button innovationButton;
    public Button statsButton;

    public GameObject videoQuad;
    
    private void Start()
    {
        welcomeButton.onClick.AddListener(DisplayWelcomeVideo);
    }

    /**
     * A listener for the welcome function.
     */
    private void DisplayWelcomeVideo()
    {
        videoQuad.SetActive(!videoQuad.activeSelf);
    }
}