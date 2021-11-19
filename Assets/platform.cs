using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    float jumpForce = 8f;
    Vector2 screenB;

    void Update()
    {
        screenB = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if(transform.position.y < screenB.y - 12)
        {
            transform.position = new Vector2(Random.Range(-screenB.x, screenB.x), screenB.y + 3);
        }
    }

    void OnCollisionEnter2D(Collision2D player)
    {
        Rigidbody2D rb = player.collider.GetComponent<Rigidbody2D>();
        if(player.relativeVelocity.y <= 0f)
        {
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
        
    }
}
