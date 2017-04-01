using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

	public GameObject busObject;
	public float gameTime = -1.0f;
	bool busAppear = true;

	void Update() {
		gameTime += Time.deltaTime;

		if (gameTime >= 0.0f && busAppear) {
			Instantiate (busObject, new Vector3 (-12.5f, 0.25f, 0), Quaternion.identity);
			busAppear = false;
		}
	}
}
