using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PhoneScene : MonoBehaviour {
	List<GameObject> slides = new List<GameObject>();
	int currentSlideNumber = 0;

	// Use this for initialization
	void Start () {
		for (int i = 1; ; ++i) {
			GameObject slide = GameObject.Find ("PhoneScene" + i);
			if (slide == null) {
				break;
			} else {
				slides.Add (slide);
			}
		}

		slides [0].GetComponent<SpriteRenderer> ().enabled = true;
		for (int i = 1; i < slides.Count; ++i) {
			slides [i].GetComponent<SpriteRenderer> ().enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			if (currentSlideNumber >= slides.Count - 1) {
				UnityEngine.SceneManagement.SceneManager.LoadScene ("Level01");
				return;
			}
			slides [currentSlideNumber].GetComponent<SpriteRenderer> ().enabled = false;
			currentSlideNumber++;
			slides [currentSlideNumber].GetComponent<SpriteRenderer> ().enabled = true;

		}

		if (Input.GetKeyDown(KeyCode.LeftArrow) && currentSlideNumber > 0) {
			slides [currentSlideNumber].GetComponent<SpriteRenderer> ().enabled = false;
			currentSlideNumber--;
			slides [currentSlideNumber].GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
