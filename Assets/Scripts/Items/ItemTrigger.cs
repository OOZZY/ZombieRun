using UnityEngine;
using System.Collections;

public class ItemTrigger : MonoBehaviour {
	GameObject globalState;
	GameObject player;

	public AudioClip pickupItem;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		globalState = GameObject.FindGameObjectWithTag ("GlobalState");
		player = GameObject.FindGameObjectWithTag ("Player");
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject == player) {
			if (name.StartsWith("health")) {
				globalState.GetComponent<GlobalState> ().health += 10;
				playAudio();
			}
			if (name.StartsWith("ammo")) {
				globalState.GetComponent<GlobalState> ().ammo += 10;
				playAudio();
			}
			Destroy (gameObject);
		}
	}

	void playAudio(){
		audio.PlayOneShot(pickupItem, 1F);
		print ("playAudio");
	}
}
