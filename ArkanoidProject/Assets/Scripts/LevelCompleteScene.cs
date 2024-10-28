using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelCompleteScene : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the text component to display the score

    private void Start()
    {
        
    }

    // Method to load the next level
    public void LoadNextLevel()
    {
        // Load the next scene in the Build Settings list
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // Check if there is a next scene
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.Log("No more levels available. Returning to the main menu.");
            SceneManager.LoadScene("MainMenu"); // If there are no more levels, return to the main menu
        }
    }

    // Method to return to the main menu
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
