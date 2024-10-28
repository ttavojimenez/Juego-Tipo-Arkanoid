using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Método para cargar el nivel 1
    public void StartGame()
    {
        SceneManager.LoadScene("Level1"); // Cambia "Level1" al nombre exacto de tu escena de nivel 1
    }

    // Método para abrir el menú de selección de niveles
    public void OpenLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection"); // Cambia "LevelSelection" al nombre de tu escena de selección de niveles (si ya la tienes o la crearás)
    }

    // Método para abrir las configuraciones de audio
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings"); // Cambia "Settings" al nombre de tu escena de configuración (si la tienes o la crearás)
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Application.Quit(); // Este método cerrará el juego. No funcionará en el editor de Unity, solo en la compilación final.
        Debug.Log("Game is exiting"); // Mensaje para verificar en el editor
    }
}
