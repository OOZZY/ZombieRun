using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	float velFactor = 10f;
	public bool grounded = true;

	// Use this for initialization
	void Start () {
	
	}

	void Jump() {
		
	}
	
	// Update is called once per frame
	void Update () {
		float accx = Input.GetAxis ("Horizontal") * velFactor;
		Vector2 acc = new Vector2 (accx, 0);
		if (accx > 0) {
			GetComponent<SpriteRenderer> ().flipX = false;
		}
		if (accx < 0) {
			GetComponent<SpriteRenderer> ().flipX = true;
		}
		//GetComponent<Rigidbody2D> ().MovePosition (transform.position + vel);
		GetComponent<Rigidbody2D> ().AddForce (acc);

		GetComponent<Rigidbody2D> ().MoveRotation (0); // no rotation

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 400));
			grounded = false;
		}
	}
}
