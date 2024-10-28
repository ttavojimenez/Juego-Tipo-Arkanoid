using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;
    private string[] persistentScenes = { "MainMenu", "LevelSelection", "Settings" }; // Define las escenas donde debe persistir

    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
        string currentScene = SceneManager.GetActiveScene().name;
        if (System.Array.IndexOf(persistentScenes, currentScene) == -1)
        {
            Destroy(gameObject);
        }
    }
}
