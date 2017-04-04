using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public bool stop = false;
	public bool gameOver = false;

	public GameObject slide;
	public GameObject movePanel;
	public GameManager gameManager;
	ObstacleManager obstacleManager;

	public int stage = 1;

	public float time = 60.0f;

	// Use this for initialization
	void Start () {
		gameManager = gameManager.GetComponent<GameManager> ();
		obstacleManager = GetComponent<ObstacleManager> ();
	}

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
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

		if (gameOver == true) {
			SceneManager.LoadScene ("FailEndingScene");
		} else if(time <= 0.0f){
			SceneManager.LoadScene ("SucessEndingScene");
		}
	}
}
