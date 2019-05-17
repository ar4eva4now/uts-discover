using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRController : MonoBehaviour
{
    GameObject camParent;
    // Update is called once per frame
    void Start()
    {
        camParent = new GameObject("camParent");
        camParent.transform.position = this.transform.position;
        this.transform.parent = camParent.transform;
        Input.gyro.enabled = true;
    }
    
    void Update()
    {
        camParent.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y * 1.8f, -Input.gyro.rotationRateUnbiased.z * (1f / 20f));
        this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x * 1.8f, 0, 0);
    }
}
