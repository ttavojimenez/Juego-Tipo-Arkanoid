using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuSoundManager : MonoBehaviour
{
    public AudioSource audioSource; // The Audio Source for button sounds
    public AudioClip hoverSound;    // The sound when hovering over the button
    public AudioClip clickSound;    // The sound when clicking the button

    private void Start()
    {
        // Make sure the AudioSource is assigned
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    // Method to play the hover sound
    public void PlayHoverSound()
    {
        audioSource.PlayOneShot(hoverSound);
    }

    // Method to play the click sound
    public void PlayClickSound()
    {
        audioSource.PlayOneShot(clickSound);
    }
}
