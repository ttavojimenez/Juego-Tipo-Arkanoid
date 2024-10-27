using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float moveSpeed = 20f;
    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position; // Save the starting position
    }

    void Update()
    {
        float inputValue = Input.GetAxisRaw("Horizontal");
        rigidbody2D.velocity = new Vector2(inputValue * moveSpeed, 0);
    }

    // Method to reset the player's position and velocity
    public void ResetPlayer()
    {
        transform.position = startPosition;
        rigidbody2D.velocity = Vector2.zero;
    }
}
