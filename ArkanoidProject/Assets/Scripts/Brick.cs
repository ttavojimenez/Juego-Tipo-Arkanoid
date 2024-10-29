using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int points = 100; // Points that this block adds when destroyed
    public GameObject[] powerUps;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            // Add points when the block is destroyed
            FindObjectOfType<GameManager>().AddPoints(points);

            // Check if the level is complete
            FindObjectOfType<GameManager>().CheckLevelComplete();

            // Call DestroyBrick to handle power-ups and destruction
            DestroyBrick();
        }
    }

    public void DestroyBrick()
    {
        // Check if power-ups are enabled for this level
        if (FindObjectOfType<GameManager>().hasPowerUps && powerUps.Length > 0 && Random.value < 0.4f)
        {
            int randomIndex = Random.Range(0, powerUps.Length);
            Instantiate(powerUps[randomIndex], transform.position, Quaternion.identity);
        }

        // Destroy the block
        Destroy(gameObject);
    }
}

