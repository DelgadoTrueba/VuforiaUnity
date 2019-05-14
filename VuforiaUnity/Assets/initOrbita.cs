using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initOrbita : MonoBehaviour {

    // Use this for initialization

    public GameObject prefab;
    public GameObject parent;
    
	public int electronesCapaK;
	public int electronesCapaL;
	public int electronesCapaM;

	void Start () {
		
        List<GameObject> electron = new List<GameObject>();
        float aux = 6.283f;

		for (int i = 0; i < electronesCapaK + electronesCapaL + electronesCapaM; i++)
        {
            electron.Add(Instantiate(prefab, transform.position, transform.rotation, parent.transform) as GameObject);
            electron[i].transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
           
			Orbita orbit = electron[i].AddComponent<Orbita>();

			if (i < electronesCapaK)
            {
				orbit.posicionInicial = aux * (i + 1) / electronesCapaK;
                orbit.orbita = 0.020f;
            }
			else if (i < electronesCapaK + electronesCapaL)
            {
				orbit.posicionInicial = aux * (i + 1) / electronesCapaL;
                orbit.orbita = 0.035f;
            }
			else if (i < electronesCapaK + electronesCapaL + electronesCapaM)
            {
				orbit.posicionInicial = aux * (i + 1) / electronesCapaM;
                orbit.orbita = 0.050f;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

    }
}
