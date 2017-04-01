using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rgd;

	public GameManager gameManager;

	public GameObject apartmentStair1;
	public GameObject apartmentStair2;
	public GameObject apartmentStair3;
	public GameObject apartmentStair4;
	public GameObject apartmentStair5;
	public GameObject apartmentStair6;
	public GameObject apartmentStair7;

	public float jump = 300.0f;
	public float speed = 0.3f;

	private bool isJump = false;

	// Use this for initialization
	void Start () {
		rgd = GetComponent<Rigidbody> ();

//		apartmentStair1 = GameObject.Find ("ApartmentStair1");
//		apartmentStair2 = GameObject.Find ("ApartmentStair2");
//		apartmentStair3 = GameObject.Find ("ApartmentStair3");
//		apartmentStair4 = GameObject.Find ("ApartmentStair4");
//		apartmentStair5 = GameObject.Find ("ApartmentStair5");
//		apartmentStair6 = GameObject.Find ("ApartmentStair6");
//		apartmentStair7 = GameObject.Find ("ApartmentStair7");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		var pos = transform.position;

		switch (gameManager.stage)
		{
			case 2:
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

	public void MoveLeft()
	{
		var pos = transform.position;
		transform.position = new Vector3 (pos.x - speed, pos.y, pos.z);

		Quaternion v3Rotation = Quaternion.Euler(0f, 180f, 0f);
		transform.rotation = v3Rotation;
	}

	public void MoveRight()
	{
		var pos = transform.position;
		transform.position = new Vector3 (pos.x + speed, pos.y, pos.z);

		Quaternion v3Rotation = Quaternion.Euler(0f, 0f, 0f);
		transform.rotation = v3Rotation;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		isJump = false;

		switch (col.gameObject.tag)
		{
			case "ApartmentStair1":
				apartmentStair1.GetComponent<PolygonCollider2D> ().enabled = false;
				break;

			case "ApartmentStair2":
				apartmentStair2.GetComponent<PolygonCollider2D> ().enabled = false;
				break;

			case "ApartmentStair3":
				apartmentStair3.GetComponent<PolygonCollider2D> ().enabled = false;
				break;

			case "ApartmentStair4":
				apartmentStair4.GetComponent<PolygonCollider2D> ().enabled = false;
				break;

			case "ApartmentStair5":
				apartmentStair5.GetComponent<PolygonCollider2D> ().enabled = false;
				break;

			case "ApartmentStair6":
				apartmentStair6.GetComponent<PolygonCollider2D> ().enabled = false;
				break;

			case "ApartmentStair7":
				apartmentStair7.GetComponent<PolygonCollider2D> ().enabled = false;
				break;

			case "NextStage":
				gameManager.stage++;

				switch (gameManager.stage)
				{
					case 2:
						Application.LoadLevel ("Gameasdf");
						break;
				}

				col.gameObject.SetActive (false);

				break;
		}
	}

	//-0.315
}
