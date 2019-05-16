using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mostratDatos : MonoBehaviour {


    public GameObject texto;

	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.I))
        {
            texto.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            texto.SetActive(false);
        }
    }
}
