using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class fpsDisplay : MonoBehaviour
{
   public TextMeshProUGUI fpsText;


	void Update () {
		fpsText.text = "FPS: " + fps.showFPS;
	}
}
