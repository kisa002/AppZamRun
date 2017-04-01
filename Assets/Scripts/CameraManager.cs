using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	private GameManager gameManager;
	private GameObject player;

	//public GameManager gameManager;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		//gameManager = gameObject.GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.stage == 1) {
			var playerPos = player.transform.position;
			transform.position = new Vector3 (transform.position.x, playerPos.y, transform.position.z);
		}
	}
}
