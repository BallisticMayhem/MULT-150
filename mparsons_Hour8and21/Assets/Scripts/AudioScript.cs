using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
       audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
       ToggleAudio();
    }

    void ToggleAudio()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.Play();
            }
        }
    }
}