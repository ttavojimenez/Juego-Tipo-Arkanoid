using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScene : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencia al texto para el puntaje

    private void Start()
    {
        // Mostrar el puntaje final en el texto
        scoreText.text = GameManager.finalScore + " POINTS";
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("Level1"); // Cargar el primer nivel nuevamente
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Cargar la escena del Menú Principal
    }
}
