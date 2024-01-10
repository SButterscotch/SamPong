using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    static public bool moving;
    public Rigidbody2D rb;
    public float moveSpeed = 1000f;
    public int targetFPS = 360;

    private float verticalInput;
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
        
        moving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S);
        
        if (moving && Input.GetKey(KeyCode.W))
        {
            movement(50f);
        }
        else if (moving && Input.GetKey(KeyCode.S))
        {
            movement(-50f);
        } else 
        {
            movement(0f);
        }
        
    }

    private void movement(float x){
        verticalInput = x;
        rb.velocity = new Vector2(rb.velocity.x, verticalInput * moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("border"))
        {
            moving = false;
        }
    }
}
