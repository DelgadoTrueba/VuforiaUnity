using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour {

    public GameObject imageTarget1;
    public GameObject imageTarget2;
    public GameObject molecula;
    public GameObject atomo1;
    public GameObject atomo2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 posicionActual;
        posicionActual = imageTarget1.transform.position;
        Vector3 posicionOtro;
        posicionOtro = imageTarget2.transform.position;

        Vector3 puntomedio = new Vector3((posicionActual.x + posicionOtro.x) / 2, (posicionActual.y + posicionOtro.y) / 2, (posicionActual.z + posicionOtro.z) / 2);

        molecula.transform.position = puntomedio;

        Vector3 Resultado = posicionActual - posicionOtro;
        
        Debug.Log(Resultado);

		if (Mathf.Abs(Resultado.x) <= 0.1f)
        {
            atomo1.SetActive(false);
            atomo2.SetActive(false);
            molecula.SetActive(true);

        }
        else
        {
            molecula.SetActive(false);
            atomo1.SetActive(true);
            atomo2.SetActive(true);
        }


    }
}
