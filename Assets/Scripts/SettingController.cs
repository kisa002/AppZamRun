using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingController : MonoBehaviour {

	public GameManager gameManager;
	public SettingManager settingManager;

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
	}
}
