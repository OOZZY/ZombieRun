using UnityEngine;
using System.Collections;

public class TitleScreenGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("IntroductionScene");
		}
	}
}
