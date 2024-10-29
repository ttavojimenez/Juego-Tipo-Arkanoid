using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int points = 100; // Points that this block adds when destroyed

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            // Add points when the block is destroyed
            FindObjectOfType<GameManager>().AddPoints(points);

            // Check if the level is complete
            FindObjectOfType<GameManager>().CheckLevelComplete();
            
            // Destroy the block
            DestroyBrick();
        }
    }

    public GameObject[] powerUps;

    public void DestroyBrick()
{
    if (powerUps.Length > 0 && Random.value < 0.35f)
    {
        int randomIndex = Random.Range(0, powerUps.Length);
        Instantiate(powerUps[randomIndex], transform.position, Quaternion.identity);
    }
    Destroy(gameObject); 
}

}
