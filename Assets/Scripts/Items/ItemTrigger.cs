using UnityEngine;
using System.Collections;

public class ItemTrigger : MonoBehaviour {
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
			if (name.StartsWith("health")) {
				player.GetComponent<PlayerBehavior> ().health += 10;
			}
			if (name.StartsWith("ammo")) {
				player.GetComponent<PlayerBehavior> ().ammo += 10;
			}
			Destroy (gameObject);
		}
	}
}
