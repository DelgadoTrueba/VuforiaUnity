using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCamera : MonoBehaviour {

	private GameObject cam;

	// Use this for initialization
	void Start () {
		cam =  GameObject.Find("ARCamera");;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mirarHaciaCamaraSinCambiarEjeX 
			= new Vector3 (this.transform.position.x, cam.transform.position.y, cam.transform.position.z);

		this.transform.LookAt(mirarHaciaCamaraSinCambiarEjeX);
	}
}
