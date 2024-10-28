using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Method to load level 1
    public void StartGame()
    {
        SceneManager.LoadScene("Level1"); 
    }

    // Method to open the level selection menu
    public void OpenLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    // Method to open audio settings
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings"); 
    }

    // Method to quit the game
    public void QuitGame()
    {
        Application.Quit(); // Este método cerrará el juego. No funcionará en el editor de Unity, solo en la compilación final.
        Debug.Log("Game is exiting"); // Mensaje para verificar en el editor
    }
}
