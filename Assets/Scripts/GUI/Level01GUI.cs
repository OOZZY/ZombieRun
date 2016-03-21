using UnityEngine;
using System.Collections;

public class Level01GUI : MonoBehaviour {
	GameObject globalState;

	// Use this for initialization
	void Start () {
		globalState = GameObject.FindGameObjectWithTag ("GlobalState");
	}
	
	// Update is called once per frame
	void Update () {
	
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
