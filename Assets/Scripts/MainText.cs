using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainText : MonoBehaviour {
	
	Text flashingText;

	// Use this for initialization
	void Start () {
		flashingText = GetComponent<Text> ();
		StartCoroutine (BlinkText());
	}

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			SceneManager.LoadScene ("Help");
		}
	}

	public IEnumerator BlinkText(){
		while (true) {
			flashingText.text = "";
			yield return new WaitForSeconds (.5f);
			flashingText.text = "Touch to Start";
			yield return new WaitForSeconds (.5f);
		}
	}
}
