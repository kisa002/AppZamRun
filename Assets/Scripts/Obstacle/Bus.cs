using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour {

	public GameObject[] busObstacles;
	GameObject bus;
	ObstacleManager obstacleManager;
	float busSpeed = 5.0f * Time.deltaTime;

	void Start() {
		obstacleManager = GetComponent<ObstacleManager> ();
		for (; transform.position.x <= 13;)
			transform.position = new Vector2 (transform.position.x + busSpeed, transform.position.y);
		StartCoroutine ("busObstacleInstantiate");
	}

	void Update () {
		
	}

	IEnumerator busObstacleInstantiate() {
		
		yield return new WaitForSeconds (4.0f);

		Instantiate (
			busObstacles [Random.Range (0, busObstacles.Length)],
			new Vector3 (4.5f, Random.Range (-1f, 5.0f), 0),
			Quaternion.identity);	
	}
}
