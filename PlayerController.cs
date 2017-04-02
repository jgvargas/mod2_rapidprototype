using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	// Physics component
	public Rigidbody rigidbody_ref;

	void Start()
	{
		rigidbody_ref = GetComponent<Rigidbody> ();
	}

	//Update: Called before a frame is rendered. 

	//FixedUpdate: Before any physics is applied
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Ribidbody: class, .AddForce to move RB
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rigidbody_ref.AddForce (movement * speed);
	}
}