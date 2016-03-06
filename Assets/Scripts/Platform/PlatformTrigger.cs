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

	void OnTriggerEnter2D() {
		player.GetComponent<PlayerMovement> ().grounded = true;
	}

	void OnTriggerExit2D() {
		player.GetComponent<PlayerMovement> ().grounded = false;
	}
}
