using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class movingText : MonoBehaviour
{
    
    public RectTransform rectTransform;
    public float scrollSpeed = 50f;
    public float wrapThreshold = 500f;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    

    void Update()
    {
        // Need to add unity engine because of ambiguity issues
        UnityEngine.Vector2 currentPosition = rectTransform.anchoredPosition;

        // Scroll horizontally
        currentPosition.x += scrollSpeed * Time.deltaTime;

        // Wrap around the screen when reaching the threshold
        if (currentPosition.x > wrapThreshold)
        {
            currentPosition.x -= wrapThreshold * 3f;
        }

        // Update the anchored position
        rectTransform.anchoredPosition = currentPosition;
    }
}
