﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Vuforia;
using Image = UnityEngine.UI.Image;

/**
 * A class to help manage the video player actions for AR.
 */
public class VideoController : MonoBehaviour, ITrackableEventHandler
{
    // GameObject fields
    private GameObject imageTarget;
    private Button pauseButton;
    
    // Class fields
    private VideoPlayer _videoPlayer;
    private TrackableBehaviour _trackableBehaviour;
    private bool _isPaused = false;

    private void Start()
    {   
        // Get the video player component
        _videoPlayer = GetComponent<VideoPlayer>();
        
        // Get the image target's trackable
        imageTarget = GameObject.Find("ImageTarget");
        pauseButton = GameObject.FindGameObjectWithTag("PauseButton").GetComponent<Button>();

        _trackableBehaviour = imageTarget.GetComponent<TrackableBehaviour>();
        if (_trackableBehaviour)
        {
            // Register it with the handler
            _trackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }
    
    /**
     * A public method to toggle the pause functionality of the video.
     * Also changes the pause button sprite.
     */
    public void TogglePause()
    {
        // Change the pause state
        _isPaused = !_isPaused;
        
        // Set the button sprite path and play/pause the video
        var filePath = "UI/uts-discover-ui-play";
        if (_isPaused)
        {
            _videoPlayer.Pause();
        }
        else
        {
            _videoPlayer.Play();
            filePath = "UI/uts-discover-ui-pause";
        }
        
        // Load the appropriate button sprite
        var sp  = Resources.Load<Sprite>(filePath);
            
        // Apply the button sprite
        pauseButton.GetComponent<Image>().sprite = sp;
    }

    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        if (_isPaused) return;
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
