using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour {

	private GameObject text;

	// Use this for initialization
	void Start () {
		text = GameObject.Find ("Text").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine (Text);
	}

	IEnumerator Text()
	{
		
		yield return new WaitForSeconds (0.1f);
	}
}
