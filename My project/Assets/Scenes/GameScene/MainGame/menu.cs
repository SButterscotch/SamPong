using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

    static public bool isPaused;
    public GameObject pauseMenu;

    public AudioSource audioSource;

    public AudioClip background;

    void Start()
    {
        Resume();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = background;
        audioSource.Play();
   
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
                Debug.Log("Resumed");
            }else if(!isPaused){
                Pause();
                Debug.Log("Paused");
            }
        }
    }

    public void Resume()
    {
        audioSource.volume = 0.5F;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        
        
    }

    public void Pause()
    {
        audioSource.volume = 0.1F;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }
}
