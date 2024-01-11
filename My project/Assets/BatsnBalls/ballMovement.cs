using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public SceneChangeScript sceneChanger;
    public float moveSpeed;

    private float speedmultiplyerx = 2f;
    private float speedmultiplyery = 2f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
        sceneChanger = FindObjectOfType<SceneChangeScript>();
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
