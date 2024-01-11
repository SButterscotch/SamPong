using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemymovement : MonoBehaviour
{

    public Rigidbody2D rb;

    public float moveSpeed = 100f;

    public GameObject ball;

    private float speedmultiplyery;

    private float initialPos;

    void Start()
    {

        initialPos = this.transform.position.x;
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
            Movement(-10f);
        } else if(this.transform.position.y < ball.transform.position.y)
        {
            Movement(10f);
        }
    }

    void Movement(float speedmultiplyery)
    {
        rb.velocity = new Vector2(0, speedmultiplyery * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("border"))
        {
            speedmultiplyery = 0f;
        }
    }

}
