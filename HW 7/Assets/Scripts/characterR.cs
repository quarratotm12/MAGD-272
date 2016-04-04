﻿using UnityEngine;
using System.Collections;

public class characterR : MonoBehaviour {

	Rigidbody2D charRB;

	float hVelocity; // store the horizontal velocity
	float vVelocity; // store the vertical velocity
	public float sprint = 2f;

	public float speedOffset = 0.2f;  // speed offset for horizontal movement, otherwise character zooms off screen

	public float jumpHeight = 7f; // the jump velocity.

	public float secondJumpHeight = 7.5f; // the second jump velocity.
	public int numOfJumps; //check for total number of jumps

	public bool onGround; // check for when character is on the ground
	bool facingRight=true;
	Animator animate;


	// Use this for initialization
	void Start () {
		charRB = gameObject.GetComponent<Rigidbody2D> ();
		animate = GetComponent<Animator> ();
		numOfJumps = 0;
	}
	
	// Update is called once per frame
	void Update () {
		hVelocity = Input.GetAxis ("Horizontal") * speedOffset;
		Debug.Log (hVelocity);
		getJump ();
		move ();
	}


	void move(){
		if (hVelocity > 0 && !facingRight)
			flip ();
		else if (hVelocity < 0 && facingRight)
			flip ();

		animate.SetFloat ("hSpeed", Mathf.Abs(hVelocity));
		if(Input.GetKey(KeyCode.LeftShift))
			charRB.transform.position = new Vector2 (charRB.transform.position.x + (hVelocity * sprint), charRB.transform.position.y);
		else
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

	void flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1.0f;
		transform.localScale = theScale;
	}

}
