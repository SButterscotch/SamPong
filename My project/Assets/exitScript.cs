using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitScript : MonoBehaviour
{
    public Button exitButton;


    void Start()
    {

        exitButton.onClick.AddListener(ExitGame);
    }

    void ExitGame()
    {

        Debug.Log("Exiting the game");


        Application.Quit();
    }
}
