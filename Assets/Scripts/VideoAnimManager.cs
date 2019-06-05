using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoAnimManager : MonoBehaviour
{
    private Animator anim;

    // Use this for initialization
	void Start () {
		anim = this.GetComponent<Animator> ();
	}

    public void exitAnim() {
		anim.SetTrigger ("CloseVideo");
    }

	public void openAnim(){
		anim.SetTrigger ("OpenVideo");
	}
}
