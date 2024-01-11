using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemymovement : MonoBehaviour
{

    public Rigidbody2D rb;

    public float moveSpeed, increaseRate;

    public GameObject ball;

    private float speedmultiplyery;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        HandleMovementInput();
    }

    void HandleMovementInput()
    {
        if(this.transform.position.y > ball.transform.position.y)
        {
            Movement(-1f);
        } else if(this.transform.position.y < ball.transform.position.y)
        {
            Movement(1f);
        }
    }

    void Movement(float speedmultiplyery)
    {
        rb.velocity = new Vector2(0, (rb.velocity.y + moveSpeed) * speedmultiplyery * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 currScale = transform.localScale;
        if (collision.gameObject.CompareTag("border"))
        {
            speedmultiplyery = 0f;
        }

        if (collision.gameObject.CompareTag("ball"))
        {
            currScale.y += increaseRate;
            transform.localScale = currScale;
        }
    }

}
