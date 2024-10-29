using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int lives = 3;              // Player's starting lives
    public int score = 100;               // Player's starting score

    // References to UI Text elements
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;
    public static int finalScore; // Static variable to save the final score

    public bool hasPowerUps;

    private void Start()
    {
        UpdateUI(); // Initialize UI with starting values
    }

    // Method to handle losing a life
    public void LoseLife()
    {
        lives--;
        UpdateUI(); // Update lives in UI
        if (lives <= 0)
        {
            finalScore = score; // Save the final score
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

    // Method to add points to the score
    public void AddPoints(int points)
    {
        score += points;
        UpdateUI(); // Update score in UI
    }

    // Method to update the lives and score in the UI
    private void UpdateUI()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
    }

    // Method to check if the level is complete
    public void CheckLevelComplete()
    {
        if (transform.childCount <= 1) // Check if all bricks are destroyed
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Load the next level
        }
    }
}
