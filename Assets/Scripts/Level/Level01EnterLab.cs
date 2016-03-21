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

	void OnTriggerStay2D(Collider2D collider) {
		if ((Input.GetKeyDown (KeyCode.DownArrow)) && globalState.GetComponent<GlobalState>().hasCureInfo) {
			if (collider.gameObject == player) {
				globalState.GetComponent<GlobalState> ().level01SpawnPosition = player.transform.position;
				UnityEngine.SceneManagement.SceneManager.LoadScene ("InsideLab");
			}
		}
	}
}
