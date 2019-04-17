using UnityEngine;
using Vuforia;

public class VideoController : MonoBehaviour, ITrackableEventHandler
{
    // GameObject fields
    public GameObject imageTarget;
    
    // Class fields
    private TrackableBehaviour _trackableBehaviour;

    private void Start()
    {
        // Get the image target's trackable
        _trackableBehaviour = imageTarget.GetComponent<TrackableBehaviour>();
        if (_trackableBehaviour)
        {
            // Register it with the handler
            _trackableBehaviour.RegisterTrackableEventHandler(this);
        }
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
            Debug.Log("Playing video...");
        }
        else
        {
            // Pause or stop the video
            Debug.Log("Stopping video...");
        }
    }
}
