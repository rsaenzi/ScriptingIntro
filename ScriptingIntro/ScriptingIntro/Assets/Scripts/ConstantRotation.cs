using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{
    [Tooltip("Rotation speed around its Z axis in degrees/seconds")]
    public float rotationSpeed;

    void Update() {

        // Rotates the game object ´rotationSpeed´ degrees per second
        this.transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime, Space.Self);
    }
}