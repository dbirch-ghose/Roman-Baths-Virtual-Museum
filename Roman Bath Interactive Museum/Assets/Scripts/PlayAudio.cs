using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;

    // Static reference to the currently playing AudioSource
    private static AudioSource currentlyPlaying;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger fired");

            // Stop the previous audio if it exists and is different
            if (currentlyPlaying != null && currentlyPlaying != audioSource)
            {
                currentlyPlaying.Stop();
            }

            audioSource.Play();
            currentlyPlaying = audioSource;
            Debug.Log("Audio playing");
        }
    }
}