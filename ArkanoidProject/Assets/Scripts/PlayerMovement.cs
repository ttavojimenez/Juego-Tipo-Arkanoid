using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to the Rigidbody2D component
    public Rigidbody2D rigidbody2D;

    // Speed at which the paddle moves
    public float moveSpeed = 20f;

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input value (-1 for left, 1 for right, 0 for no input)
        float inputValue = Input.GetAxisRaw("Horizontal");

        // Set the rigidbody's velocity directly based on input and move speed
        rigidbody2D.velocity = new Vector2(inputValue * moveSpeed, 0);
    }
}
