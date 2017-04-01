using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float jump = 300.0f;

	private Rigidbody rgd;
	private bool isJump = false;

	// Use this for initialization
	void Start () {
		rgd = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Jump()
	{
		if (isJump == false) {
			Vector3 force = transform.up * jump;
			rgd.AddForce (force);

			isJump = true;
		}
	}

	void OnCollisionEnter(Collision col)
	{
		isJump = false;
	}
}
