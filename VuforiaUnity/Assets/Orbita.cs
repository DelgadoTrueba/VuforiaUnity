using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour {

	float timeCounter;

	public float speed;

	public float posX;
	public float posZ;

	// Use this for initialization
	void Start () {
		timeCounter = 0f;

		/*speed = 1f;*/
	
		if (posX == 0.02f) {
			timeCounter = 1f;
		}
		if (posX == 0.04) {
			timeCounter = 1.5f;
		}
		if (posX == 0.06f) {
			timeCounter = 1.75f;
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
