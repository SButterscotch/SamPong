using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class glow : MonoBehaviour
{
    public PostProcessVolume gloww;
    private Bloom lighting;
    // Start is called before the first frame update
    void Start()
    {
        gloww = GetComponent<PostProcessVolume>();
        gloww.profile.TryGetSettings(out lighting);
    }

    // Update is called once per frame
    void Update()
    {
        bool move = MovementScript.moving;
        if (move)
        {
            lighting.intensity.value = 25f;
        }
        else
        {
            lighting.intensity.value -= 0.5f;
        }
    }
}
