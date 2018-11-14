using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	GameObject player;
	float maxHorizontalDistance = 1f;
	float maxVerticalDistance = 4f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;

		float rightDistance = player.transform.position.x - transform.position.x;
		if (rightDistance > maxHorizontalDistance) {
			newPosition.x += rightDistance - maxHorizontalDistance;
		}

		float leftDistance = transform.position.x - player.transform.position.x;
		if (leftDistance > maxHorizontalDistance) {
			newPosition.x -= leftDistance - maxHorizontalDistance;
		}

		float upDistance = player.transform.position.y - transform.position.y;
		if (upDistance > maxVerticalDistance) {
			newPosition.y += upDistance - maxVerticalDistance;
		}

		float downDistance = transform.position.y - player.transform.position.y;
		if (downDistance > maxVerticalDistance) {
			newPosition.y -= downDistance - maxVerticalDistance;
		}

		transform.position = newPosition;
	}
}
