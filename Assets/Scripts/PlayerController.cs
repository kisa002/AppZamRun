using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rgd;
	public GameManager gameManager;

	public float jump = 300.0f;
	public float speed = 0.1f;

	private bool isJump = false;

	// Use this for initialization
	void Start () {
		rgd = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		var pos = transform.position;

		switch (gameManager.stage)
		{
			case 2:
				transform.position = new Vector3 (pos.x + speed, pos.y, pos.z);

				break;
		}
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
