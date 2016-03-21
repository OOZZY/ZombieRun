using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {
	GameObject globalState;

	float velFactor = 10f;
	public bool grounded = true;

    Animator anim;

	public AudioClip shoot;
	AudioSource audio;

    // Use this for initialization
    void Start () {
		globalState = GameObject.FindGameObjectWithTag ("GlobalState");
        anim = GetComponent<Animator>();
		audio = GetComponent<AudioSource>();

		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name.Equals ("Level01")) {
			transform.position = globalState.GetComponent<GlobalState> ().level01SpawnPosition;
		}

		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name.Equals ("InsideLab")) {
			transform.position = globalState.GetComponent<GlobalState> ().labSpawnPosition;
		}
	}

	// Update is called once per frame
	void Update () {
		float direction = Input.GetAxis ("Horizontal");
		float accx = direction * velFactor;
        anim.SetFloat("speed", Mathf.Abs(accx));
		Vector2 acc = new Vector2 (accx, 0);
		if (accx > 0) {
			GetComponent<SpriteRenderer> ().flipX = false;
		}
		if (accx < 0) {
			GetComponent<SpriteRenderer> ().flipX = true;
		}
		//GetComponent<Rigidbody2D> ().MovePosition (transform.position + vel);
		GetComponent<Rigidbody2D> ().AddForce (acc);

		GetComponent<Rigidbody2D> ().MoveRotation (0); // no rotation

		if ((Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.W)) && grounded) {
			// jump
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 400));
			grounded = false;
		}

		if (Input.GetKeyDown (KeyCode.Space) && globalState.GetComponent<GlobalState> ().ammo > 0) {
			audio.PlayOneShot(shoot, 0.7F);
			if (!GetComponent<SpriteRenderer> ().flipX) {
				Instantiate (Resources.Load ("bullet"), transform.position + (new Vector3(2, 0)), transform.rotation);
			} else {
				GameObject bullet = (GameObject)Instantiate (Resources.Load ("bullet"), transform.position + (new Vector3(-2, 0)), transform.rotation);
				bullet.GetComponent<SpriteRenderer> ().flipX = true;
			}
			globalState.GetComponent<GlobalState> ().ammo--;
		}

		if (globalState.GetComponent<GlobalState> ().health <= 0) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("TitleScreen");
		}
	}

	void OnGUI() {
		GUIContent content = new GUIContent ("framerate: " + (int)(1.0f / Time.smoothDeltaTime));
		GUIStyle style = new GUIStyle ();
		style.normal.textColor = Color.black;
		GUI.Label (new Rect (10, 10, 100, 100), content, style);

		content = new GUIContent ("health: " + globalState.GetComponent<GlobalState>().health);
		GUI.Label (new Rect (10, 30, 100, 100), content, style);

		content = new GUIContent ("ammo: " + globalState.GetComponent<GlobalState>().ammo);
		GUI.Label (new Rect (10, 50, 100, 100), content, style);
	}
}
