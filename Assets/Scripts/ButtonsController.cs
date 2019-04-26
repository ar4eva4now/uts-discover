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
    public GameObject helpPanel;
    public Button welcomeButton;
    public Button locationButton;
    public Button innovationButton;
    public Button statsButton;
    public Button helpButton;

    
    private void Start()
    {
        welcomeButton.onClick.AddListener(DisplayWelcomeVideo);
        statsButton.onClick.AddListener(DisplayStatsAnimation);
        //helpButton.onClick.AddListener(DisplayHelpMenu);
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
    
    /**
     * A listener for the help menu function.
     */
    //private void DisplayHelpMenu()
    //{
        // Hide or show the stats quad
        //helpPanel.SetActive(!helpPanel.activeSelf);
        //var filePath = helpPanel.activeSelf ? "uts-discover-ui-exit" : "uts-discover-ui-help";
        //var sp  = Resources.Load<Sprite>(filePath);
        //helpButton.GetComponent<Image>().sprite = sp;
    //    playHelpAnimation();
    //}

}