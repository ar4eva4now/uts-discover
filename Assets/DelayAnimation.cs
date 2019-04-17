using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DelayAnimation : MonoBehaviour
{

    public Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        StartCoroutine (AnimationDelay());
    }
    
    IEnumerator AnimationDelay(){
        anim.Stop();
        yield return new WaitForSeconds (1);
        anim.Play("animate_stat");
    }

}
