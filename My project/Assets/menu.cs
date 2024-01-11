using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public string GameName;

    public string ExitName;


    public void ToGame()
    {
         SceneManager.LoadSceneAsync(GameName);
    }

    public void ExitGame()
    {
        SceneManager.LoadSceneAsync(ExitName);
    }
    
}
