using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fail : MonoBehaviour {

	public GameObject fail1;
	public GameObject fail2;

	public Button replay;
	public Button exit;

	float time = 0;
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time >= 3f) {
			fail1.SetActive (false);
			replay.enabled = true;
			exit.enabled = true;
		}
	}

	public void Replay() {
		SceneManager.LoadScene ("Help");
	}

	public void Exit() {
		Application.Quit ();
	}
}
