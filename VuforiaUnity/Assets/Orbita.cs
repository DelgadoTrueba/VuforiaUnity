﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour {

	public float posicionInicial;

	private float speed;

	public float orbita;

	// Use this for initialization
	void Start () {

		speed = 1;

	}
	
	// Update is called once per frame
	void Update () {
		posicionInicial += Time.deltaTime * speed;

		float x = Mathf.Cos (posicionInicial) * orbita;
		float y = 0.00f;
		float z = Mathf.Sin (posicionInicial) * orbita;

		transform.position = new Vector3 (x, y, z);
	}
}
