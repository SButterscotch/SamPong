using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelManager : MonoBehaviour
{
    public string sceneName, tipsMenu;
    public void levelChanger()
    {
        SceneManager.LoadSceneAsync(sceneName);
        Time.timeScale = 1;    
    }

    public void toTips()
    {
        SceneManager.LoadSceneAsync(tipsMenu);
    }

    public void exitGame()
    {
        Debug.Log("Exiting the gamne");
        Application.Quit();
    }
}
