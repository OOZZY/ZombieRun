using UnityEngine;
using System.Collections;

public class Level01EnterHouse : MonoBehaviour {
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
		if (collider.gameObject == player && globalState.GetComponent<GlobalState>().powerStarted && !globalState.GetComponent<GlobalState>().hasCureInfo) {
			globalState.GetComponent<GlobalState> ().objective = "Press down to enter the house.";
		}
	}

	void OnTriggerStay2D(Collider2D collider) {
		if ((Input.GetKeyDown (KeyCode.DownArrow)) && globalState.GetComponent<GlobalState>().powerStarted) {
			if (collider.gameObject == player) {
				globalState.GetComponent<GlobalState> ().level01SpawnPosition = player.transform.position;
				globalState.GetComponent<GlobalState> ().objective = "Use the computer to search for a cure.";
				UnityEngine.SceneManagement.SceneManager.LoadScene ("InsideHouse");
			}
		}
	}
}
