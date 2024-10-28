using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject[] powerUps; // Array of Power-Up prefabs
    public float powerUpDropChance = 0.2f; // 20% drop chance

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().AddPoints(100);

            // Check if a Power-Up should drop
            if (Random.value < powerUpDropChance)
            {
                int randomIndex = Random.Range(0, powerUps.Length);
                Instantiate(powerUps[randomIndex], transform.position, Quaternion.identity);
            }

            Destroy(gameObject);
        }
    }
}

