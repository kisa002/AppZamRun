using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour {

	public float obstacleSpeed;
	
	// Update is called once per frame
	void Update () {
		obstacleSpeed = 5.0f * Time.deltaTime;

		transform.position = new Vector2 (transform.position.x - obstacleSpeed, 0);

		destroy ();
	}

	void destroy() {
		Vector3 view = Camera.main.WorldToScreenPoint(transform.position);

		if(view.x < -10) {
			Destroy(gameObject);
		}
	}
}
