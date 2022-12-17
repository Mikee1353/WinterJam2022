using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private float Horizontal;
    private float speed = 8f;
    private float jumpingPower = 10f;
    private bool isFacing = true;
    public Animator anim;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        anim.SetBool("Run", false);
        anim.SetBool("jump", false);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
           
            anim.SetBool("Run", true);
            
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            anim.SetBool("jump", true);
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y >0f)
        {
            anim.SetBool("jump", true);
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y *0.5f);
        }

        Flip();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Horizontal * speed, rb.velocity.y);
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip()
    {
        if(isFacing && Horizontal < 0 || !isFacing && Horizontal > 0)
        {
            isFacing = !isFacing;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
    }
}
