using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sucess : MonoBehaviour {

	public void replay() {
		SceneManager.LoadScene ("Help");
	}

	public void exit() {
		Application.Quit ();
	}
}
