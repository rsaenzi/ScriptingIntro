using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class EnemyPlatformMotion : MonoBehaviour
{
    public float motionSpeed = 1.0f;
    public float platformWidth = 2.0f;

    private SpriteRenderer sprite;
    private Vector2 initialPosition;
    private Vector2 motionDirection;
    private bool goingToRight = true;

    void Start() {
        sprite = this.GetComponent<SpriteRenderer>();
        initialPosition = this.transform.position;
        sprite.flipX = false;
    }

    void Update()
    {
        if (this.transform.position.x > initialPosition.x + (platformWidth / 2)) {
            goingToRight = false;
            sprite.flipX = true;
        }
        if (this.transform.position.x < initialPosition.x - (platformWidth / 2)) {
            goingToRight = true;
            sprite.flipX = false;
        }

        motionDirection = goingToRight ? Vector2.right : Vector2.left;
        this.transform.Translate(motionDirection * motionSpeed * Time.deltaTime);
    }
}
