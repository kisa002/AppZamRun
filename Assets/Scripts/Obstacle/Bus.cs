using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ObstacleManager))]
public class Bus : MonoBehaviour {

	ObstacleManager obstacleManager;
	GameObject bus;

	// Use this for initialization
	void Start () {
		obstacleManager = GetComponent<ObstacleManager> ();

		//for(; transform.position.x <= 13.0f; )
			//bus.transform.position.x += 5.0f * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void busAppear() {
		bus = Instantiate (obstacleManager.bus, new Vector3 (-17.5f, 2, 0), Quaternion.identity) as GameObject;
	}
}
