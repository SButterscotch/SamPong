using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    static public bool collided = false;
    public Rigidbody2D rb;

    public SceneChangeScript sceneChanger;
    public float moveSpeed, speedChange;

    private float speedmultiplyerx = 2f;
    private float speedmultiplyery = 2f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
        sceneChanger = FindObjectOfType<SceneChangeScript>();

//start in a random y spot

        float randomFloat = Random.Range(-5f, 5f);

        this.transform.position = new Vector2(transform.position.x, randomFloat);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2((rb.velocity.x + moveSpeed) * speedmultiplyerx * Time.deltaTime, (rb.velocity.y + moveSpeed) * speedmultiplyery * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("border"))
        {
            speedmultiplyery = -speedmultiplyery;
            
            
        } 
        else if(collision.gameObject.CompareTag("Player"))
        {
            speedmultiplyerx = -speedmultiplyerx;
            collided = true;

//If hit player then increase speed

            if(transform.position.x < 0)
            {
                moveSpeed += speedChange;
            }
        }
         else if(collision.gameObject.CompareTag("borderX") && this.transform.position.x > 0)
        {
            
            sceneChanger.ChangeToScene("winningScene");
        }
        else if(collision.gameObject.CompareTag("borderX") && this.transform.position.x < 0)
        {
            sceneChanger.ChangeToScene("losingScene");
        }
    }

}
