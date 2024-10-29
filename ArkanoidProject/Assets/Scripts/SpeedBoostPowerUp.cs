using UnityEngine;

public class SpeedBoostPowerUp : PowerUpBase
{
    public float speedMultiplier = 1.5f;

    public override void ActivatePowerUp(GameObject player)
    {
        // Aumenta la velocidad de la bola
        Rigidbody2D ballRb = player.GetComponent<Rigidbody2D>();
        ballRb.velocity *= speedMultiplier;
    }
}
