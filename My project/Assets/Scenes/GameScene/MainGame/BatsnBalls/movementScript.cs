using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    static public bool moving;
    static public int currentScore;
    public Rigidbody2D rb;
    public float moveSpeed, decreaseRate, speedIncrease;  
    private float verticalInput;


    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        currentScore =0;
    }

    void Update()
    {
        
        HandleMovementInput();

    }

    void HandleMovementInput()
    {
        
        moving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow);
        
        if (moving && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            Movement(1f);
        }
        else if (moving && (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
        {
            Movement(-1f);
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
        Vector2 currScale = transform.localScale;

        if (collision.gameObject.CompareTag("border"))
        {
            moving = false;
        } 
//decreases y scale everytime player hits ball, however increase speed to balance it

        if (collision.gameObject.CompareTag("ball"))
        {
            currScale.y -= decreaseRate;
            currScale.y = Mathf.Abs(currScale.y);
            transform.localScale = currScale;

            moveSpeed += speedIncrease;
            currentScore++;

        }
    }
}
