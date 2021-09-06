using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public float motionSpeed = 1.0f;
    //public float amplitude = 1.0f;

    private Vector2 initialScale;
    private float offset;
    private float currentAngle;

    void Start() {
        initialScale = this.transform.localScale;
    }

    void Update() {
        currentAngle += motionSpeed * Time.deltaTime;
        offset = Mathf.Sin(currentAngle) * 0.5f + 1.5f;
        this.transform.localScale = initialScale * offset;
    }
}
