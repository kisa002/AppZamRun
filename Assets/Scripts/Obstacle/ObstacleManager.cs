using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {

	public float obstacleSpeed;

	public GameObject bus;
	public GameObject[] busObstacle;
	public GameObject[] trashObstacle;

	public void destroy() {
		Vector3 view = Camera.main.WorldToScreenPoint(transform.position);

		if(view.x < -50) {          
			Destroy(gameObject);
		}
	}

	public void instantiate(GameObject obstacle) {
		obstacle = Instantiate (
			busObstacle[Random.Range(0, busObstacle.Length)],
			new Vector3 (4.5f, Random.Range(-1f, 5.0f), 0),
			Quaternion.identity) as GameObject;
	}
}
