using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoAnimManager : MonoBehaviour
{
    public Animator anim;
    //public Button exitButton;


    // Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
        //exitButton.onClick.AddListener(exitAnim);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void exitAnim() {
		anim.SetTrigger ("CloseVideo");
        //gameObject.SetActive(!gameObject.activeSelf);
    }

	public void openAnim(){
		anim.SetTrigger ("OpenVideo");
        //gameObject.SetActive(!gameObject.activeSelf);
	}
}
