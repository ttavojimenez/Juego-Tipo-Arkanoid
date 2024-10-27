using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3;

    // Method to handle losing a life
    public void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {
            SceneManager.LoadScene("GameOver"); // Load the Game Over scene if lives run out
        }
        else
        {
            ResetLevel(); // Reset level if lives are still remaining
        }
    }

    // Method to reset the level by repositioning the ball and player
    public void ResetLevel()
    {
        FindObjectOfType<BallPhysics>().ResetBall();
        FindObjectOfType<PlayerMovement>().ResetPlayer();
    }
}
