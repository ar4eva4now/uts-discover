using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  Class to manage animation delays.
 */
public class DelayAnimationScript : MonoBehaviour
{
    public Animator anim;
    public float wait;

    void Start() {
        anim = GetComponent<Animator>();
        StartCoroutine (AnimationDelay());
    }
    
    void Update() {
        anim = GetComponent<Animator>() ;
        StartCoroutine (AnimationDelay());
    }

    /*
        Delay start of an animation by user-specified wait time.
     */
    public IEnumerator AnimationDelay(){
        anim.enabled = false;
        yield return new WaitForSeconds (wait);
        anim.enabled = true;
    }

}
