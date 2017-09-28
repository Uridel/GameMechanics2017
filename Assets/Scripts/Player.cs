using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float moveSpeed = 5;
    public float jumpHeight = 2;
    public int playerLives = 3;


    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private float moveVelocity = 10;
    private bool grounded;
    private bool doubleJumped;
    public bool unlockDoubleJump = false;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().freezeRotation = true;
        playerLives = 1;

    }

    //happens 0.1 times a secondm good for physics stuff
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update () {
      
        if (grounded && unlockDoubleJump)
        {
            doubleJumped = false;
        }

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && grounded)
        {
            Jump();
           

        }
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && !grounded && !doubleJumped)
        {
            Jump();
           
            doubleJumped = true;

        }

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.D))
        {
           
            moveVelocity = moveSpeed;

        }
        if (Input.GetKey(KeyCode.A))
        {
            
            moveVelocity = -moveSpeed;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        

    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
}
