using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter1Control : MonoBehaviour
{
    private Rigidbody2D rb2;
    public float speed = 1;
    public int jumpSpeed;
    



    bool canJump = true;
    bool faceRight = true;

    Animator animator;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        

    }
    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");
        rb2.velocity = new Vector2(moveInput * speed, rb2.velocity.y);
        if (moveInput > 0 || moveInput < 0)
        {
            animator.SetBool("isRunning", true);
            
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (faceRight == true && moveInput < 0)
        {
            Flip();
        }
        else if (faceRight == false && moveInput > 0)
        {
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.W))
        {
            Jump();
            animator.SetTrigger("fall");
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2.AddForce(Vector2.left * speed);
            
        }
       
        if (Input.GetKey(KeyCode.D))
        {
            rb2.AddForce(Vector2.right * speed);
         
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform"|| collision.transform.tag == "Box")
        {
            canJump = true;
        }
    }


    void Jump()
    {
        if (canJump)
        {
            rb2.AddForce(Vector2.up * jumpSpeed);
            canJump = false;
            animator.SetTrigger("jump");
        }
        
    }

    

    void Flip()
    {
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
    
}
