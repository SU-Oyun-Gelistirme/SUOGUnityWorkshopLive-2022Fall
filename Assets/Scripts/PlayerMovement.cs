using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int movespeed;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var velocityHor = Input.GetAxis("Horizontal"); 
        var velocityVer = Input.GetAxis("Vertical"); 
        Vector2 velocity = new Vector2(velocityHor, velocityVer);
        velocity = Vector2.ClampMagnitude(velocity, 1f);
        rb.velocity = velocity * movespeed;
    }
}
