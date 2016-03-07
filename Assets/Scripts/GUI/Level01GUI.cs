using UnityEngine;
using System.Collections;

public class Level01GUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUIContent content = new GUIContent ("framerate: " + (int)(1.0f / Time.smoothDeltaTime));
		GUIStyle style = new GUIStyle ();
		style.normal.textColor = Color.black;
		GUI.Label (new Rect (10, 10, 100, 100), content, style);
	}
}
