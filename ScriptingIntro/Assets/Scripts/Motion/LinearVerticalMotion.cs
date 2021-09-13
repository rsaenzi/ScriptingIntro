using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearVerticalMotion : MonoBehaviour
{
    public float motionSpeed = 1.0f;

    void Update()
    {
        this.transform.Translate(Vector2.right * motionSpeed * Time.deltaTime);
    }
}
