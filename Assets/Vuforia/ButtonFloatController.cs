using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFloatController : MonoBehaviour
{
    public float verticleSpeed;
    public float horizontalSpeed;
    public float amplitude;
    public Vector3 tempPosition;
    // Start is called before the first frame update
    void Start()
    {
        tempPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPosition.x += horizontalSpeed;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticleSpeed) * amplitude;
        transform.position = tempPosition;
    }
}
