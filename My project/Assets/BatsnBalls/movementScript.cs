using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 1000f;
    public int targetFPS = 360;

    void Start()
    {
        Application.targetFrameRate = targetFPS;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        float verticalInput = Input.GetKey(KeyCode.W) ? 50f : (Input.GetKey(KeyCode.S) ? -50f : 0f);
        rb.velocity = new Vector2(rb.velocity.x, verticalInput * moveSpeed * Time.deltaTime);
    }
}
