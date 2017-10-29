using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	public float  moveSpeed =  0;
	public float jumpHeight = 0;
	public int playerLives = 0;
    public int checkpoint = 0;


    public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
    public Vector3 currentCheckpoint;
	private float moveVelocity= 0;
	private bool grounded;
	private bool doubleJumped;
    public bool touchingIce;
    public float newMove;
	public bool unlockDoubleJump = false;



	void Start(){
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		playerLives = 1;

	}

  

    //happens 0.1 times a secondm good for physics stuff
    void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
        newMove = moveSpeed * 0.8f;

    }

	void Update () {
		if (grounded && unlockDoubleJump) {
			doubleJumped = false;
		}

		if ((Input.GetKeyDown(KeyCode.Space )|| Input.GetKeyDown(KeyCode.W))&& grounded){
			Jump();
			//GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

		}if ((Input.GetKeyDown(KeyCode.Space )|| Input.GetKeyDown(KeyCode.W))&& !grounded && !doubleJumped){
			Jump ();
			//GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
			doubleJumped = true;
			
		} 

		moveVelocity = 0f;

		if (Input.GetKey(KeyCode.D)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
			
		} if (Input.GetKey(KeyCode.A)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
		}

        if (touchingIce)
        {
            
            Debug.Log("work");
            // Apply input as a force instead of setting velocity directly.
            GetComponent<Rigidbody2D>().AddForce(new Vector2(moveVelocity * newMove, GetComponent<Rigidbody2D>().velocity.y));
        }
        else
        {
            // Set Velocity Directly
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        }

    }

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}

	public void UnlockDoubleJump(Collider2D other){
		if (other.name == "PowerUP") {
			unlockDoubleJump = true;
		}
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ice")
        {
            touchingIce = true;
        }else
        {
            touchingIce = false;
        }
        if (col.gameObject.tag == "Bullet")
        {
            playerLives--;
            Destroy(col.gameObject);
        }
    }

    

}
