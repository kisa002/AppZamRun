using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		var playerPos = player.transform.position;
		transform.position = new Vector3 (transform.position.x, playerPos.y, transform.position.z);
	}
}
