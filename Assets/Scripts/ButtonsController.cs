using UnityEngine;
using UnityEngine.UI;

/**
 * A class to help manage button actions.
 */
public class ButtonsController : MonoBehaviour
{
    // GameObject fields
    public GameObject videoQuad;
    public GameObject statsQuad;
    public Button welcomeButton;
    public Button locationButton;
    public Button innovationButton;
    public Button statsButton;
    
    private void Start()
    {
        welcomeButton.onClick.AddListener(DisplayWelcomeVideo);
        statsButton.onClick.AddListener(DisplayStatsAnimation);
    }

    /**
     * A listener for the welcome function.
     */
    private void DisplayWelcomeVideo()
    {
        // Hide or show the video quad
        videoQuad.SetActive(!videoQuad.activeSelf);
    }
    
    /**
     * A listener for the stats function.
     */
    private void DisplayStatsAnimation()
    {
        // Hide or show the stats quad
        statsQuad.SetActive(!statsQuad.activeSelf);
    }
}