using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	float velFactor = 10f;
	float accx;
	public Vector2 velocity;

	// Use this for initialization
	void Start () {
	
	}

	void Jump() {
		
	}
	
	// Update is called once per frame
	void Update () {
		accx = Input.GetAxis ("Horizontal") * velFactor;
		Vector2 acc = new Vector2 (accx, 0);
		if (accx > 0) {
			GetComponent<SpriteRenderer> ().flipX = false;
		}
		if (accx < 0) {
			GetComponent<SpriteRenderer> ().flipX = true;
		}
		//GetComponent<Rigidbody2D> ().MovePosition (transform.position + vel);
		GetComponent<Rigidbody2D> ().AddForce (acc);

		velocity = GetComponent<Rigidbody2D> ().velocity;

		GetComponent<Rigidbody2D> ().MoveRotation (0); // no rotation

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 400));
		}
	}
}
