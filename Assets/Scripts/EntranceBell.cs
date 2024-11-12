using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class EntranceBell : MonoBehaviour
{
    public AudioSource soundSource;
    private bool firstPlayerTrigger;

    // Start is called before the first frame update
    void Start()
    {
        if (soundSource != null)
        {
            soundSource.volume = 1.0f;
            soundSource.Play();
        }

        firstPlayerTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (soundSource == null)
            return;

        if (other.CompareTag("Player"))
        {
            if (!firstPlayerTrigger)
            {
                firstPlayerTrigger = true;
                soundSource.Stop();
                soundSource.volume = 1.0f;
            }

            if (!soundSource.isPlaying)
            {
                soundSource.Play();
            }
        }
    }
}
