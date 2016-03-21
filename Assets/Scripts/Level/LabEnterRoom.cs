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
