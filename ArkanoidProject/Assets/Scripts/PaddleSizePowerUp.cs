using UnityEngine;
using System.Collections;

public class PaddleSizePowerUp : PowerUpBase
{
    public float sizeMultiplier = 1.5f;
    public float duration = 6f; 

    public override void ActivatePowerUp(GameObject player)
    {
        
        StartCoroutine(TempSizeChange(player));
    }

    private IEnumerator TempSizeChange(GameObject player)
    {
        
        Vector3 originalScale = player.transform.localScale;

        
        player.transform.localScale = new Vector3(originalScale.x * sizeMultiplier, originalScale.y, originalScale.z);

        
        yield return new WaitForSeconds(duration);

        
        player.transform.localScale = originalScale;
    }
}
