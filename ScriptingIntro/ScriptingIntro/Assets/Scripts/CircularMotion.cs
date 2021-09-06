using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public float angularSpeed = 1.0f;
    public float circleRadius = 1.0f;

    private Vector2 initialPosition;
    private Vector2 offset;
    private float currentAngle;

    void Start() {
        initialPosition = this.transform.position;
    }

    void Update() {
        currentAngle += angularSpeed * Time.deltaTime;
        offset = new Vector2(Mathf.Sin(currentAngle), Mathf.Cos(currentAngle)) * circleRadius;
        this.transform.position = initialPosition + offset;
    }
}
