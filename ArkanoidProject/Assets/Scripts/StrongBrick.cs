using UnityEngine;

public class StrongBrick : MonoBehaviour
{
    public int hitsRequired = 3; // Number of hits to destroy this brick
    private int currentHits = 0;

    private SpriteRenderer spriteRenderer; // For visual updates

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            currentHits++;

            if (currentHits >= hitsRequired)
            {
                FindObjectOfType<GameManager>().AddPoints(150); // Add points
                Destroy(gameObject); // Destroy the brick
            }
            else
            {
                UpdateVisual(); // Update the look of the brick
            }
        }
    }

    private void UpdateVisual()
    {
        // Change color based on remaining hits
        float colorValue = 1 - ((float)currentHits / hitsRequired);
        spriteRenderer.color = new Color(1, colorValue, colorValue); // Fades to red
    }
}
