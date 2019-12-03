using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionAtCertainX : MonoBehaviour {

	public float XLimit;
	public float XSpawn;
	Vector3 newPos;

	void Update () {
		if(transform.localPosition.x <= XLimit){
			newPos = transform.localPosition;
			newPos.x = XSpawn;
			transform.localPosition = newPos;
		}
	}
}
