using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float degreesPerSecond = 45.0f;
    float updown = 2f;
    void Update()
    {
        transform.Rotate(0, degreesPerSecond * Time.deltaTime, 0);
        transform.Translate(Vector3.up * Time.deltaTime * updown * Mathf.Sin(Time.time));
    }
}
