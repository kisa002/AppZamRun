using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
	
	public float ScrollSpeed = 0.5f;
	float Offset;

	void Update()
	{
		Offset += Time.deltaTime * ScrollSpeed;
		gameObject.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Offset, 0);
	}
}
