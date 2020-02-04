using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	Rigidbody2D rb;
	public float speed;

	//jump vars
	public float jumpSpeed = 5f;
	public Transform groundCheckPoint;
	public float groundCheckRaduis;
	public LayerMask groundLayer;
	private bool grounded;

	//animation controll
	public Animator animator;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRaduis, groundLayer);
		float mov = Input.GetAxis ("Horizontal");

		if(mov < 0f) {
			transform.localScale = new Vector2 (-1f,transform.localScale.y);
			animator.SetFloat ("speed", 0.3f);
			rb.velocity = new Vector2 (mov * speed * 1.5f, rb.velocity.y);//Vector 2(x,y)
		}
		else if (mov > 0f) {
			transform.localScale = new Vector2 (1f,transform.localScale.y);
			animator.SetFloat ("speed", 0.3f);
			rb.velocity = new Vector2 (mov * speed, rb.velocity.y);
		}
		else {
			animator.SetFloat ("speed", 0);
			rb.velocity = new Vector2 (0, rb.velocity.y);

		}

		if (Input.GetButtonDown ("Jump") && grounded) {
			rb.velocity = new Vector2 (rb.velocity.x, jumpSpeed);
		}
		animator.SetBool ("jump", !grounded);

	}
}
