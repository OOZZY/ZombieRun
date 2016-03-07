using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
	GameObject player;
	float xvel;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player.transform.position.x < transform.position.x) {
			xvel = 1f;
		}
		if (player.transform.position.x > transform.position.x) {
			xvel = -1f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		newPosition.x += xvel;
		transform.position = newPosition;
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.name.Equals ("zombie(Clone)")) {
			Destroy (collider.gameObject);
		}
			
		Destroy (gameObject);
	}
}
