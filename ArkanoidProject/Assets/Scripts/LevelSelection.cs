using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    // Method to Main Menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");  
    }

    // Method to load Level 1
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1"); 
    }

    // Method to load Level 2
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2"); 
    }

    // Method to load Level 3
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
}
