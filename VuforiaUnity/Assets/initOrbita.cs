using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initOrbita : MonoBehaviour {

    // Use this for initialization

    public GameObject prefab;
    public GameObject parent;
    public int numElectrones;

	void Start () {
        List<GameObject> electron = new List<GameObject>();
        float aux = 6.283f;

        for (int i = 0; i < numElectrones; i++)
        {
            electron.Add(Instantiate(prefab, transform.position, transform.rotation, parent.transform) as GameObject);
            electron[i].transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            Orbita orbit = electron[i].AddComponent<Orbita>();
            if (i < 2)
            {
                orbit.posicionInicial = aux * (i + 1) / 2;
                orbit.orbita = 0.020f;
            }
            else if (i < 10)
            {
                orbit.posicionInicial = aux * (i + 1) / 8;
                orbit.orbita = 0.035f;
            }
            else
            {
                orbit.posicionInicial = aux * (i + 1) / 18;
                orbit.orbita = 0.050f;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

    }
}
