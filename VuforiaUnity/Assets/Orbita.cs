using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour {

	public float timeCounter;

	private float speed;

	public float posX;
	public float posZ;

	// Use this for initialization
	void Start () {
		/*timeCounter = 0f;*/

		speed = 1;

		if (posX == 0.015f) {
			timeCounter += 0f;
		}
		if (posX == 0.0225f) {
			timeCounter += 2.25f;
		}
		if (posX == 0.030f) {
			timeCounter += 1.25f;
		}	
	}
	
	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime * speed;

		float x = Mathf.Cos (timeCounter) * posX;
		float y = 0.00f;
		float z = Mathf.Sin (timeCounter) * posZ;

		transform.position = new Vector3 (x, y, z);
	}
}
