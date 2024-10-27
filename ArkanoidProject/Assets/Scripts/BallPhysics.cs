using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    // Reference to the Rigidbody2D component
    public Rigidbody2D rigidBody2D;

    // Speed at which the ball moves
    public float speed = 6f; // Using a lower value since it's now directly controlling velocity

    // Start is called before the first frame update
    void Start()
    {
        // Set initial velocity with a random x value and consistent y value
        Vector2 velocity = new Vector2(Random.Range(-1f, 1f), 1).normalized * speed;

        // Directly assign the velocity to the Rigidbody2D
        rigidBody2D.velocity = velocity;
    }
}
