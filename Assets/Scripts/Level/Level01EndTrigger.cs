using UnityEngine;
using System.Collections;

public class Level01EndTrigger : MonoBehaviour {
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject == player) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("TitleScreen");
		}
	}
}
