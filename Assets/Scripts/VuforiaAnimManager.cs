﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using Image = UnityEngine.UI.Image;

public class VuforiaAnimManager : MonoBehaviour, ITrackableEventHandler
{
    private GameObject imageTarget;
    private TrackableBehaviour _trackableBehaviour;
    private Animator anim;
    private bool _isFirstLoad;
    public float wait;

    // Start is called before the first frame update
    void Start()
    {
        imageTarget = GameObject.Find("ImageTarget");
        anim = this.GetComponent<Animator>();
        anim.enabled = false;

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
            // Play animation
            StartCoroutine(AnimationDelay());
            //anim.enabled = true;
        }
        else
        {
            // Stop animation
            anim.enabled = false;
        }
    }

    private IEnumerator AnimationDelay(){
        anim.enabled = false;
        yield return new WaitForSeconds(wait);
        anim.enabled = true;
    }
}
