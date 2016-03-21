using UnityEngine;
using System.Collections;

public class ZombieBehaviour : MonoBehaviour {
	GameObject player;
	public int health = 30;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1.5f, 0f);

		if (health <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject == player) {
			player.GetComponent<PlayerBehavior> ().health -= 10;
			health -= 10;
		}
	}
}
