using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Speed Settings")]
    [Range(0f, 50f)]
    public float runSpeed = 2f;
    public float movementSmoothing = 0.05f;
    [Header("Jump Settings")]
    public float jumpForce = 400f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public int Jumps = 0;
    [Header("Animation Settings")]
    public Animator animator;

    private Rigidbody2D rigidbody2D;
    private float horizontalMove = 0f;
    private Vector3 currentVelocity;
    public float compensationSpeed = 10f;
    private bool facingRight = true;
    private bool jumpPressed = false;
    private bool isGrounded = false;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("MovementBool", true);
        }
        else
        {
            animator.SetBool("MovementBool", false);
        }
    }

    private void FixedUpdate()
    {

        isGrounded = false;
        Collider2D[] groundColliders = Physics2D.OverlapCircleAll(groundCheck.position, groundCheckRadius, groundLayer);
        for (int i = 0; i < groundColliders.Length; i++)
        {
            if (groundColliders[i].gameObject != this.gameObject)
            {
                isGrounded = true;
                Jumps = 0;
            }
        }
        Move(horizontalMove * Time.fixedDeltaTime);
        if (horizontalMove > 0f && !facingRight)
        {
            Flip();
            // FLIP TO THE RIGHT
        }
        else if (horizontalMove < 0f && facingRight)
        {
            Flip();
        }
    }
    private void Move(float _move)
    {
        Vector3 targetVelocity = new Vector2(horizontalMove, rigidbody2D.velocity.y);
        rigidbody2D.velocity = Vector3.SmoothDamp(rigidbody2D.velocity, targetVelocity, ref currentVelocity, movementSmoothing);

        if (jumpPressed && isGrounded)
        {
            rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            jumpPressed = false;
            isGrounded = false;
        }
        else if (jumpPressed && Jumps < 1)
        {
                rigidbody2D.AddForce(new Vector2(0f, jumpForce));
                Jumps = Jumps + 1;
        }
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 targetScale = transform.localScale;
        targetScale.x *= -1;
        transform.localScale = targetScale;
    }
}