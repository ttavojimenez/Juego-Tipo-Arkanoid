using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Assign the pause menu Canvas in the Inspector
    private bool isPaused = false;

    private void Update()
    {
        // Detects if the player presses the "Esc" key to pause or unpause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Hides the pause menu
        Time.timeScale = 1f; // Restores game time
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); // Shows the pause menu
        Time.timeScale = 0f; // Stops game time
        isPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f; // Ensures time returns to normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restarts the current scene
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f; // Ensures time returns to normal
        SceneManager.LoadScene("MainMenu"); // Change "MainMenu" to the exact name of your main scene
    }
}
