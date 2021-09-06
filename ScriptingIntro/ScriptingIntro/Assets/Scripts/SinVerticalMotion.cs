using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinVerticalMotion : MonoBehaviour
{
    public float motionSpeed = 1.0f;
    public float amplitude = 1.0f;

    private Vector2 initialPosition;
    private Vector2 offset;
    private float currentAngle;

    void Start() {
        initialPosition = this.transform.position;
    }

    void Update() {
        currentAngle += motionSpeed * Time.deltaTime;
        offset = new Vector2(0, Mathf.Sin(currentAngle)) * amplitude;
        this.transform.position = initialPosition + offset;
    }
}
