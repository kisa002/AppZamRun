using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class MoveLeft : EventTrigger {

	private PlayerController player;

	bool isClick = false;

	public override void OnPointerDown(PointerEventData eventData)
	{
		player = GameObject.Find ("Player").GetComponent<PlayerController>();

		isClick = true;
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		player = GameObject.Find ("Player").GetComponent<PlayerController>();

		isClick = false;
	}

	void Update()
	{
		if (isClick == true)	
			player.MoveLeft ();
	}
}
