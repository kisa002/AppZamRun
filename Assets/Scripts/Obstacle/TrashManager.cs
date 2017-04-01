using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour {

	public GameObject[] trashObstacles;

	ObstacleManager obstacleManager;

	// Use this for initialization
	void Start () {
		obstacleManager = GetComponent<ObstacleManager> ();

		StartCoroutine ("trashObstacleInstantiate");
	}

	IEnumerator trashObstacleInstantiate() {
		while (true) {
			print ("asdf");
			yield return new WaitForSeconds (1.25f);

			Instantiate(trashObstacles[Random.Range(0, trashObstacles.Length)],
				new Vector3(13.5f, 0.0f, 0),
				Quaternion.identity);
		}
	}
}
