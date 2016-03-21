using UnityEngine;
using System.Collections;

public class GlobalState : MonoBehaviour {
	public int health = 100;
	public int ammo = 10;

	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
