using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps : MonoBehaviour
{
    public int targetFPS = 165;
    public static int showFPS = 165;

    void Start()
    {
        QualitySettings.vSyncCount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = targetFPS;
    }
}
