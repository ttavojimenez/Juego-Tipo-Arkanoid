using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int points = 100; // Puntos que este bloque añade al ser destruido

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            // Sumar puntos al destruir el bloque
            FindObjectOfType<GameManager>().AddPoints(points);

            // Revisar si el nivel está completo
            FindObjectOfType<GameManager>().CheckLevelComplete();
            
            // Destruir el bloque
            Destroy(gameObject);
        }
    }
}
