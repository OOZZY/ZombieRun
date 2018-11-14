using UnityEngine;
using System.Collections;

public class ZombieSpawnerTrigger : MonoBehaviour {
	GameObject player;
	bool triggered = false;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject == player && !triggered) {
			Instantiate (Resources.Load("zombie"), transform.position, transform.rotation);
			triggered = true;
		}
	}
}
