using UnityEngine;
using System.Collections;

public class StartPower : MonoBehaviour {
	GameObject globalState;
	GameObject player;

	// Use this for initialization
	void Start () {
		globalState = GameObject.FindGameObjectWithTag ("GlobalState");
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject == player && !globalState.GetComponent<GlobalState>().powerStarted) {
			globalState.GetComponent<GlobalState> ().objective = "Press E to power the power plant.";
		}
	}

	void OnTriggerStay2D(Collider2D collider) {
		if ((Input.GetKeyDown (KeyCode.E))) {
			if (collider.gameObject == player) {
				print ("Power Started");
				globalState.GetComponent<GlobalState> ().objective = "Go back home.";
				globalState.GetComponent<GlobalState> ().powerStarted = true;
			}
		}
	}
}
