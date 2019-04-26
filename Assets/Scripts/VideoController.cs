using UnityEngine;
using UnityEngine.Video;
using Vuforia;

/**
 * A class to help manage the video player actions for AR.
 */
public class VideoController : MonoBehaviour, ITrackableEventHandler
{
    // GameObject fields
    public GameObject imageTarget;
    
    // Class fields
    private VideoPlayer _videoPlayer;
    private TrackableBehaviour _trackableBehaviour;

    private void Start()
    {   
        // Get the video player component
        _videoPlayer = GetComponent<VideoPlayer>();
        
        // Get the image target's trackable
        _trackableBehaviour = imageTarget.GetComponent<TrackableBehaviour>();
        if (_trackableBehaviour)
        {
            // Register it with the handler
            _trackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    
    /**
     * A public function to toggle the gameObject's display.
     */
    public void ToggleDisplay()
    {
        // Hide or show the encapsulating object
        gameObject.SetActive(!gameObject.activeSelf);
    }

    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        // On state change for detection
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play the video
            _videoPlayer.Play();
        }
        else
        {
            // Pause or stop the video
            _videoPlayer.Pause();
        }
    }
}
