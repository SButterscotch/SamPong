using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bg;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Background();
    }

    // Update is called once per frame
    public void Background()
    {
        audioSource.clip = bg;
        audioSource.volume = 0.5F;
        audioSource.Play();
    }
}
