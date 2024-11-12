using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioSource musicSource; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))  
        {
            if (musicSource != null && !musicSource.isPlaying)
            {
                musicSource.Play();  
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))  
        {
            if (musicSource.isPlaying)
            {
                musicSource.Pause(); 
            }
        }
    }
}

