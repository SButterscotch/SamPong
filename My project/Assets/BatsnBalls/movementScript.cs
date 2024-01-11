using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    static public bool moving;
    public Rigidbody2D rb;
    public float moveSpeed = 1000f;  
    private float verticalInput;
    void Start()
    {
        
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
            Movement(50f);
        }
        else if (moving && Input.GetKey(KeyCode.S))
        {
            Movement(-50f);
        } else 
        {
            Movement(0f);
        }
        
    }

    private void Movement(float x){
        verticalInput = x;
        rb.velocity = new Vector2(0, verticalInput * moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("border"))
        {
            moving = false;
        } 
    }
}
