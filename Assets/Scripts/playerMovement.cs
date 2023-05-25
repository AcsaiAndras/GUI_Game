using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    float dirX = 0f;
    SpriteRenderer sprite;
    [SerializeField] float moveSpeed = 7f;
    [SerializeField] float jumpForce = 16f;

    enum MovementState 
    {
        idle, runnig, jumping, falling
    }

    

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);


        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x,jumpForce);
        }

        UpdateAnimationState();
        
    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (rb.velocity.x > 0f)
        {
            state = MovementState.runnig;
            sprite.flipX = false;
            
        }
        else if (rb.velocity.x < 0f)
        {
            state = MovementState.runnig;
            sprite.flipX = true;
            
        }
        else
        {
            
            state = MovementState.idle;

        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }
}
