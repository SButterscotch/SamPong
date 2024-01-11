using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreDisplay : MonoBehaviour
{

    public TextMeshProUGUI textbox;
    void Update()
    {
        textbox.text = "Score: " + MovementScript.currentScore;
    }
}
