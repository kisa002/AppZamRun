using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour {

	public GameManager gameManager;
	private SettingManager settingManager;

	// Use this for initialization
	void Start () {
		gameManager = gameManager.gameObject.GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update () {

	}

	public void OnClick()
	{
		if (gameManager.stop == false)
			gameManager.stop = true;
		else
			gameManager.stop = false;
		
		transform.FindChild ("SettingPanel").gameObject.SetActive (gameManager.stop);
		print ("A");
	}

	public void Continue()
	{
		gameManager.stop = false;

		transform.FindChild ("SettingPanel").gameObject.SetActive(gameManager.stop);
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void Restart()
	{
		SceneManager.LoadScene ("Game-HAEYUM");
	}
}
