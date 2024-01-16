using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour
{
    static public bool moving;
    public Rigidbody2D rb;
    private float moveSpeed = 1000;  
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
            Debug.Log("up");
            Movement(2f);
        }
        else if (moving && Input.GetKey(KeyCode.S))
        {
            Debug.Log("down");
            Movement(-2f);
        } else 
        {
            Movement(0f);
        }
        
    }



    private void Movement(float x){
        verticalInput = x;
        rb.velocity = new Vector2(0, (rb.velocity.y + moveSpeed) * verticalInput * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("border"))
        {
            moving = false;
        } 


    }
}
