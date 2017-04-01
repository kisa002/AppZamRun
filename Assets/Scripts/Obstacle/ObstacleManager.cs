using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

	public GameObject busObject;
	public float gameTime = -1.0f;
	bool busAppear = true;
	GameObject busO;

	void Update() {
		gameTime += Time.deltaTime;

		if (gameTime >= 0.0f && busAppear) {
			busO = Instantiate (busObject, new Vector3 (-12.5f, 2, 0), Quaternion.identity) as GameObject;
			busAppear = false;
		}
	}

	public void destroy() {
		Vector3 view = Camera.main.WorldToScreenPoint(transform.position);

		if(view.x < -50) {          
			Destroy(gameObject);
		}
	}
}
