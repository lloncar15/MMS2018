﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {
	public bool isFlat = true;
	private Rigidbody2D rigid;

	private void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		Vector3 tilt = Input.acceleration;
		if (isFlat)
			tilt = Quaternion.Euler (90, 0, 0) * tilt;
		rigid.AddForce (tilt);
	}
}
