using UnityEngine;
using System.Collections;

public class Level01EnterLab : MonoBehaviour {
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
			globalState.GetComponent<GlobalState> ().objective = "Press down to enter the lab.";
		}
	}

	void OnTriggerExit2D(Collider2D collider) {
		if (collider.gameObject == player) {
			if (name.Equals ("EnterLabFromRoomWithKey")) {
				globalState.GetComponent<GlobalState> ().objective = "Find the key.";
			}

			if (name.Equals ("EnterLabFromRoomWithCure")) {
				globalState.GetComponent<GlobalState> ().objective = "Find the cure.";
			}
		}
	}

	void OnTriggerStay2D(Collider2D collider) {
		if ((Input.GetKeyDown (KeyCode.DownArrow)) && globalState.GetComponent<GlobalState>().hasCureInfo) {
			if (collider.gameObject == player) {
				globalState.GetComponent<GlobalState> ().level01SpawnPosition = player.transform.position;
				if (!globalState.GetComponent<GlobalState> ().hasKey) {
					globalState.GetComponent<GlobalState> ().objective = "Find the unlocked room.";
				} else {
					globalState.GetComponent<GlobalState> ().objective = "Find the room with the cure.";
				}
				UnityEngine.SceneManagement.SceneManager.LoadScene ("InsideLab");
			}
		}
	}
}
