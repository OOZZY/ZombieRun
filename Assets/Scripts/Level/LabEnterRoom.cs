using UnityEngine;
using System.Collections;

public class LabEnterRoom : MonoBehaviour {
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
		if (collider.gameObject == player) {
			if (name.Equals ("EnterLabRoom6")) {
				globalState.GetComponent<GlobalState> ().objective = "This room is unlocked. Press down to enter the room.";
			}
			if (name.Equals ("EnterLabRoom10") && !globalState.GetComponent<GlobalState> ().hasKey) {
				globalState.GetComponent<GlobalState> ().objective = "This room is locked. You need to find the key.";
			}
			if (name.Equals ("EnterLabRoom10") && globalState.GetComponent<GlobalState> ().hasKey) {
				globalState.GetComponent<GlobalState> ().objective = "This room is locked. Press down to use the key.";
			}
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.gameObject == player) {
			if (!globalState.GetComponent<GlobalState> ().hasKey) {
				globalState.GetComponent<GlobalState> ().objective = "Find the unlocked room.";
			} else {
				globalState.GetComponent<GlobalState> ().objective = "Find the room with the cure.";
			}
		}
	}

	void OnTriggerStay2D(Collider2D collider) {
		if ((Input.GetKeyDown (KeyCode.DownArrow))) {
			if (collider.gameObject == player) {
				if (name.Equals ("EnterLabRoom6")) {
					globalState.GetComponent<GlobalState> ().labSpawnPosition = player.transform.position;
					UnityEngine.SceneManagement.SceneManager.LoadScene ("UnlockedRoomWithKey");
				}
				if (name.Equals ("EnterLabRoom10") && globalState.GetComponent<GlobalState> ().hasKey) {
					globalState.GetComponent<GlobalState> ().labSpawnPosition = player.transform.position;
					UnityEngine.SceneManagement.SceneManager.LoadScene ("LockedRoom10");
				}
			}
		}
	}
}
