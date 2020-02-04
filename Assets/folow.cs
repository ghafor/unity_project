using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folow : MonoBehaviour {

	public Transform player;
	public float smooth=0.125f;
	public Vector3 offset;

	
	// Update is called once per frame

	void FixedUpdate () {
		Vector3 desired_position = player.position;
		Vector3 smoothed_position = Vector3.Lerp (transform.position,desired_position,smooth);
		//transform.position = new Vector3 (player.position.x,player.position.y,-10f);
		transform.position = smoothed_position;
		//transform.LookAt (player);
	}
}
