using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScene : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the text for the score

    private void Start()
    {
        // Display the final score in the text
        scoreText.text = GameManager.finalScore + " POINTS";
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("Level1"); // Reload the first level
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Load the Main Menu scene
    }
}
