using System.Collections;
using UnityEngine;

/*
 *  Class to manage animation delays.
 */
public class AnimationManager : MonoBehaviour
{
    public Animator anim;
    public float wait;

    private void Update() {
        StartCoroutine(AnimationDelay());
    }

    /*
     *  Delay start of an animation by user-specified wait time.
     */
    private IEnumerator AnimationDelay(){
        anim.enabled = false;
        yield return new WaitForSeconds(wait);
        // ReSharper disable once Unity.InefficientPropertyAccess
        anim.enabled = true;
    }

}
