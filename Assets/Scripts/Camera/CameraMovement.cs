using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	GameObject player;
	float maxDistance = 8f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		float rightDistance = player.transform.position.x - transform.position.x;
		if (rightDistance > maxDistance) {
			Vector3 newPosition = transform.position;
			newPosition.x += rightDistance - maxDistance;
			transform.position = newPosition;
		}

		float leftDistance = transform.position.x - player.transform.position.x;
		if (leftDistance > maxDistance) {
			Vector3 newPosition = transform.position;
			newPosition.x -= leftDistance - maxDistance;
			transform.position = newPosition;
		}
	}
}
