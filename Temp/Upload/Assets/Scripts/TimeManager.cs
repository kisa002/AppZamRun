using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class TimeManager : MonoBehaviour {

	public Slider slider;
	private GameManager gameManager;
	//public GameManager gameManager;

	// Use this for initialization
	void Start () {
		//gameManager = GetComponent<GameManager> ();
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

		StartCoroutine ("Timer");

	}

	void FixedUpdate()
	{
		slider.value = gameManager.time;
	}

	IEnumerator Timer()
	{
		while (!gameManager.gameOver) {
			yield return new WaitForSeconds (0.1f);

			gameManager.time -= 0.1f;

			if (gameManager.time <= 0.0f) {
				gameManager.gameOver = true;
			}
		}
	}
}
