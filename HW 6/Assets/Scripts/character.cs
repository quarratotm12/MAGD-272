using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {

	Rigidbody2D charRB;

	float hVelocity; // store the horizontal velocity
	float vVelocity; // store the vertical velocity

	public float speedOffset = 0.2f;  // speed offset for horizontal movement, otherwise character zooms off screen

	public float jumpHeight = 7f; // the jump velocity.

	public float secondJumpHeight = 7.5f; // the second jump velocity.
	public int numOfJumps; //check for total number of jumps

	public bool onGround; // check for when character is on the ground


	// Use this for initialization
	void Start () {
		charRB = gameObject.GetComponent<Rigidbody2D> ();
		numOfJumps = 0;
	}
	
	// Update is called once per frame
	void Update () {
		hVelocity = Input.GetAxis ("Horizontal") * speedOffset;
		getJump ();
		move ();
	}


	void move(){

		charRB.transform.position = new Vector2 (charRB.transform.position.x + hVelocity, charRB.transform.position.y);
		charRB.velocity += (Vector2.up * vVelocity);
	}

	void getJump(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			if(numOfJumps == 1){ 
				vVelocity = secondJumpHeight;
				numOfJumps++;
			}
			if (onGround) {
				vVelocity = jumpHeight;
				numOfJumps++;
			}
		} else {
			vVelocity = 0;
		}
	}

	void OnTriggerEnter2D(Collider2D coll){ //check for touching ground
		if(coll.CompareTag("Ground")){
			onGround = true;
			numOfJumps = 0;
		}
	}

	void OnTriggerExit2D(Collider2D coll){ //check for leaving ground
		if (coll.CompareTag ("Ground")) {
			onGround = false;
		}
	}
		

}
