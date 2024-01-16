using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip press, background;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        BG();
    }

    public void Button()
    {
 
        audioSource.clip = press;
        audioSource.Play();
    }

    public void BG()
    {

        audioSource.clip = background;
        audioSource.volume = 0.3F;
        audioSource.Play();
    }

    

    
}
