using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitAnimManager : MonoBehaviour
{
    public Animator anim;
    public Button exitButton;

    DisplayController displayController;

    // Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		// anim.Play ("VideoOpenAnim", -1, float.NegativeInfinity);
        exitButton.onClick.AddListener(exitAnim);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void exitAnim() {
        // Reverse animation play
		anim.SetFloat ("Direction", -1);
		anim.Play ("VideoOpenAnim", -1, float.NegativeInfinity);
        displayController.Toggle();
    }
}
