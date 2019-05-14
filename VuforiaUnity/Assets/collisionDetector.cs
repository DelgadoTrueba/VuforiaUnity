using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetector : MonoBehaviour {

    public GameObject imageTarget;
    public GameObject molecula;
    public GameObject selfAtomo;
    public GameObject otherAtomo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 posicionActual;
        posicionActual = this.transform.position;

        Vector3 posicionOtro;
        posicionOtro = imageTarget.transform.position;

        Vector3 Resultado = posicionActual - posicionOtro;
        Debug.Log(Resultado);

        if (Resultado.x <= 0.1f)
        {
            selfAtomo.SetActive(false);
            otherAtomo.SetActive(false);
            molecula.SetActive(true);

        }
        else
        {
            molecula.SetActive(false);
            selfAtomo.SetActive(true);
            otherAtomo.SetActive(true);
        }


    }

    void OnTriggerEnter (Collider c)
    {
      
        molecula.SetActive(true);
        
    }

    void OnTriggerExit(Collider c)
    {
        molecula.SetActive(false);
      
    }
}
