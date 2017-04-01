using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour {

	public float obstacleSpeed;

	void Update () {
		obstacleSpeed = 5.0f * Time.deltaTime;

		transform.position = new Vector2 (transform.position.x - obstacleSpeed, transform.position.y);

		destroy ();
	}

	void destroy() {
		Vector3 view = Camera.main.WorldToScreenPoint(transform.position);

		if(view.x < -10) {          
			Destroy(gameObject);
		}
	}
}
