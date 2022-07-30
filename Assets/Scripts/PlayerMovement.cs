using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float horizontalMovement;
    public float verticalMovement;
    public float speed = 4.0f;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();

        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        verticalMovement = Input.GetAxis("Vertical");

        Vector2 movementDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;

        rb.velocity = new Vector2(horizontalMovement * speed, rb.velocity.y);

        
    }
}
