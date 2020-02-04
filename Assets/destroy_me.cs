using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_me : MonoBehaviour {
	//Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col) {
		Destroy (gameObject);
	} 

}
