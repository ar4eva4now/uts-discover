using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStartScript : MonoBehaviour
{

    public GameObject stat;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine ("StartDelay");
    }

    // Update is called once per frame
    void Update() {
        
    }

    IEnumerator StartDelay() {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 6f;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        // stat.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
