using UnityEngine;
using System.Collections;

public class UseComputer : MonoBehaviour {
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
		if (collider.gameObject == player && !globalState.GetComponent<GlobalState>().hasCureInfo) {
			globalState.GetComponent<GlobalState> ().objective = "Press E to use the computer.";
		}
	}

	void OnTriggerStay2D(Collider2D collider) {
		if ((Input.GetKeyDown (KeyCode.E))) {
			if (collider.gameObject == player) {
				globalState.GetComponent<GlobalState> ().hasCureInfo = true;
				globalState.GetComponent<GlobalState> ().objective = "Find the lab with the cure.";
				UnityEngine.SceneManagement.SceneManager.LoadScene ("UseComputer");
			}
		}
	}
}
