using UnityEngine;
using System.Collections;

public class LabEnterRoom : MonoBehaviour {
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay2D(Collider2D collider) {
		if ((Input.GetKeyDown (KeyCode.DownArrow))) {
			if (collider.gameObject == player) {
				UnityEngine.SceneManagement.SceneManager.LoadScene ("InsideLabRoom");
			}
		}
	}
}
