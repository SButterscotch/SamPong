using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{

    static public bool isPaused;
    public GameObject pauseMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }else{
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 1;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
