using UnityEngine;
using System.Collections;

public class GlobalState : MonoBehaviour {
	public int health = 100;
	public int ammo = 10;
	public bool powerStarted = false;
	public Vector3 level01SpawnPosition = new Vector3(-8.23f, 0, 0);
	public bool hasCureInfo = false;
	public Vector3 labSpawnPosition = new Vector3 (-10, -2.75621f, 0);
	public bool hasKey = false;
	public string objective = "Find the power plant.";

	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad (this);
	}

	// Update is called once per frame
	void Update () {

	}
}
