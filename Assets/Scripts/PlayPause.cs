using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioSource musicSource;
    private bool playerTrigger;

    void Start()
    {
        if (musicSource != null)
        {
            musicSource.volume = 0.0f;
            musicSource.Play();
        }

        playerTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (musicSource == null)
            return;

        if (other.CompareTag("Player"))  
        {
            if (!playerTrigger)
            {
                playerTrigger = true;
                musicSource.Stop();
                musicSource.volume = 1.0f;
            }

            if (!musicSource.isPlaying)
            {
                musicSource.Play();  
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (musicSource == null)
            return;

        if (other.CompareTag("Player"))  
        {
            if (musicSource.isPlaying)
            {
                musicSource.Pause(); 
            }
        }
    }
}

