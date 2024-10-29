using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public float speed = 6f;
    private Vector2 startPosition;

    public AudioSource audioSource;

    public AudioClip playerSound, brickSound, wallSound, gameOverSound, strongBrickSound;

    private void Start()
    {
        startPosition = transform.position;
        LaunchBall();
    }

    // Method to launch the ball with a random x direction
    private void LaunchBall()
    {
        Vector2 velocity = new Vector2(Random.Range(-1f, 1f), 1).normalized * speed;
        rigidBody2D.velocity = velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GameOver"))
        {
            audioSource.clip = gameOverSound;
            audioSource.Play();
            FindObjectOfType<GameManager>().LoseLife();
        }

        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            audioSource.clip = playerSound;
            audioSource.Play();
        }

        if (collision.gameObject.GetComponent<Brick>())
        {
            audioSource.clip = brickSound;
            audioSource.Play();
        }

        if (collision.gameObject.GetComponent<StrongBrick>())
        {
            audioSource.clip = strongBrickSound;
            audioSource.Play();
        }

        if (collision.transform.CompareTag("Wall"))
        {
            audioSource.clip = wallSound;
            audioSource.Play();
        }

        // Ajuste de ángulo para evitar ángulos fijos
        Vector2 newVelocity = rigidBody2D.velocity;

        // Evita que el ángulo sea demasiado horizontal o vertical
        if (Mathf.Abs(newVelocity.x) < 0.1f)
        {
            newVelocity.x += Random.Range(0.2f, 0.4f) * Mathf.Sign(newVelocity.x);
        }
        if (Mathf.Abs(newVelocity.y) < 0.1f)
        {
            newVelocity.y += Random.Range(0.2f, 0.4f) * Mathf.Sign(newVelocity.y);
        }

        rigidBody2D.velocity = newVelocity.normalized * speed;
    }

    // Resets the ball position and launches it again after reset
    public void ResetBall()
    {
        transform.position = startPosition;
        rigidBody2D.velocity = Vector2.zero;
        Invoke("LaunchBall", 1.0f); // Delay before relaunching
    }
}

