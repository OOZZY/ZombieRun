using UnityEngine;
using System.Collections;

public class PlatformTrigger : MonoBehaviour {
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject == player) {
			player.GetComponent<PlayerBehavior> ().grounded = true;
		}
	}

	void OnTriggerStay2D(Collider2D collider) {
		if (collider.gameObject == player) {
			player.GetComponent<PlayerBehavior> ().grounded = true;
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.gameObject == player) {
			player.GetComponent<PlayerBehavior> ().grounded = false;
		}
	}
}
