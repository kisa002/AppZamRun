using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool stop = false;
	public bool gameOver = false;

	public GameObject slide;
	public GameObject movePanel;
	public GameManager gameManager;

	public int stage = 1;

	public float time = 60.0f;

	// Use this for initialization
	void Start () {
		gameManager = gameManager.GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (stage)
		{
			case 1:
				slide.SetActive (true);
				movePanel.SetActive (false);
				break;

			case 2:
				slide.SetActive (false);
				movePanel.SetActive (true);
				break;
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "NextStage")
		{
			gameManager.stage += 1;
		}
	}
}
