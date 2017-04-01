using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour {

	public GameObject[] busObstacles;
	GameObject bus;
	float busSpeed = 5.0f * Time.deltaTime;

	void Start() {
		StartCoroutine ("busObstacleInstantiate");
	}

	IEnumerator busObstacleInstantiate() {
		while (transform.position.x < 13) {
			yield return new WaitForSeconds (0.01f * Time.deltaTime);
			transform.position = new Vector2 (transform.position.x + busSpeed, transform.position.y);
		}

		while (transform.position.x >= 13) {
			yield return new WaitForSeconds (1.5f);

			Instantiate (
				busObstacles [Random.Range (0, busObstacles.Length)],
				new Vector3 (4.5f, Random.Range (-2.5f, 0f), 0),
				Quaternion.identity);
		}
	}
}
