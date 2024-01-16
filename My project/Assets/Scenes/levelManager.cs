using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelManager : MonoBehaviour
{
    public string sceneName;
    public void levelChanger()
    {
        SceneManager.LoadSceneAsync(sceneName);
        Time.timeScale = 1;    
    }
}
