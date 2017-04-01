using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour {

	public GameObject[] busObstacles;
	GameObject bus;
	ObstacleManager obstacleManager;

	void Start() {
		obstacleManager = GetComponent<ObstacleManager> ();
	}

	void Update () {
		for (; transform.position.x <= 13;)
			transform.position = new Vector2 (transform.position.x + 5.0f * Time.deltaTime, transform.position.y);

		//StartCoroutine (busObstacleInstantiate ());
	}

//	IEnumerator busObstacleInstantiate() {
//		while (transform.position.x >= 13) {
//			yield return new WaitForSeconds (1);
//
//			GameObject obstacle = Instantiate (
//				busObstacles [Random.Range (0, busObstacles.Length)],
//				new Vector3 (4.5f, Random.Range (-1f, 5.0f), 0),
//				Quaternion.identity) as GameObject;
//		}
//	}
}
