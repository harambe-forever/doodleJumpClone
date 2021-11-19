using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    float movement = 0f;
    float movementSpeed = 10f;
    Vector2 screenB;

    void Update()
    {
        screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        movement = Input.GetAxis("Horizontal") * movementSpeed;      
        if(rb.velocity.x < 0f)
        {
            transform.localScale = new Vector3(0.8971807f, 0.9523771f, 0.8611006f);
        }
        if (rb.velocity.x > 0f)
        {
            transform.localScale = new Vector3(-0.8971807f, 0.9523771f, 0.8611006f);
        }
        if(transform.position.x > screenB.x + 0.3f)
        {
            transform.position = new Vector3(-screenB.x - 0.3f, transform.position.y, -5);
        }
        if (transform.position.x < -screenB.x - 0.3f)
        {
            transform.position = new Vector3(screenB.x + 0.3f, transform.position.y, -5);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "death")
        {
            Time.timeScale = 0f;
        }
    }
}
