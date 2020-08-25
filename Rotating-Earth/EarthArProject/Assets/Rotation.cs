using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	public float speed = 150f;

	public bool Rotating = false;
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, Time.deltaTime * speed, 0, Space.Self);
	}
}
