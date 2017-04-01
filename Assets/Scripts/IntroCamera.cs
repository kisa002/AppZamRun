using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroCamera : MonoBehaviour {

	bool run = true;

	void Start () {
		StartCoroutine ("Home");	
	}
	
	IEnumerator Home()
	{
		while (run) {
			var pos = transform.position;
			transform.position = new Vector3 (pos.x, pos.y - 0.03f, pos.z);

			if (transform.position.y <= -6.57)
				run = false;
			
			yield return new WaitForSeconds (0.01f);
		}

		yield return new WaitForSeconds (2.0f);


	}
}
