using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger is fired");
        if (other.tag == "Player" && !audioSource.isPlaying)
        {
            audioSource.Play();
            Debug.Log("Audio playing");
        }
    }
}
