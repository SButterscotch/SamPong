using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChangeScript : MonoBehaviour
{

    private string scene;
    // Call this method to load a new scene
    public void ChangeToScene(string sceneName)
    {
        scene = sceneName;
        SceneManager.LoadScene(scene);
        
    }

}

