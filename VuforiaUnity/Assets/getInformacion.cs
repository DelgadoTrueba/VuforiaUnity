using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getInformacion : MonoBehaviour {

    private string prueba = "This is a test";
    private string prueba2 = "This is a testeroni";
    public int hola;
    public GameObject target;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnGUI()
    {
        if (Input.GetKey(KeyCode.I) && target.activeSelf)
        {
            if (hola == 1)
                GUI.TextField(new Rect(10, 10, 200, 20), prueba);

            if (hola == 2)
                GUI.TextField(new Rect(10, 20, 200, 20), prueba2);
        }
    }
}
