using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMoleculas : MonoBehaviour {

	// Target
	public GameObject targetOxigeno;
	public GameObject targetHidrogeno;
	public GameObject targetCarbono;
	public GameObject targetNitrogeno;
	public GameObject targetSodio;
	public GameObject targetCloro;


	//Molecula de Agua
	public bool isOxigeno;
	public bool isHidrogeno;
	public GameObject moleculaDeAgua;

	//Molecula de Metano
	public bool isCarbono;
	//public bool isHidrogeno;
	public GameObject moleculaDeMetano;

	//Molecula de Amoniaco
	public bool isNitrogeno;
	//public bool isHidrogeno;
	public GameObject moleculaDeAmoniaco;

	//Molecula de Monoxido De Carbono
	//public bool isOxigeno;
	//public bool isCarbono;
	public GameObject moleculaDeMonoxidoDeCarbono;

	//Molecula Sal Comun
	public bool isSodio;
	public bool isCloro;
	public GameObject moleculaDeSalComun;

	// Atomos
	private GameObject atomoOxigeno;
	private GameObject atomoHidrogeno;
	private GameObject atomoCarbono;
	private GameObject atomoNitrogeno;
	private GameObject atomoSodio;
	private GameObject atomoCloro;


	// Use this for initialization
	void Start () {
		isOxigeno = false;
		isHidrogeno = false;
		isCarbono = false;
		isNitrogeno = false;
		isSodio = false;
		isCloro = false;

		atomoOxigeno = targetOxigeno.transform.GetChild (0).gameObject;
		atomoHidrogeno = targetHidrogeno.transform.GetChild (0).gameObject;
		atomoCarbono = targetCarbono.transform.GetChild (0).gameObject;
		atomoNitrogeno = targetNitrogeno.transform.GetChild (0).gameObject;
		atomoSodio = targetSodio.transform.GetChild (0).gameObject;
		atomoCloro = targetCloro.transform.GetChild (0).gameObject;
	}

	// Update is called once per frame
	void Update () {

		if (condicionesNecesariasMoledulaDeAgua ()) {

			Vector3 posOxigeno = targetOxigeno.transform.position;
			Vector3 posHidrogeno = targetHidrogeno.transform.position;

			if (distanciaMinimaParaGenerarMoledula(posOxigeno, posHidrogeno))
			{
				moleculaDeAgua.transform.position = 
					calcularPtoMedio (posOxigeno, posHidrogeno);

				atomoOxigeno.SetActive (false);
				atomoHidrogeno.SetActive (false);
				moleculaDeAgua.SetActive (true);
			} 
		}
		else if(condicionesNecesariasMoledulaDeMetano())
		{
			Vector3 posCarbono = targetCarbono.transform.position;
			Vector3 posHidrogeno = targetHidrogeno.transform.position;

			if (distanciaMinimaParaGenerarMoledula(posCarbono, posHidrogeno))
			{
				moleculaDeMetano.transform.position = 
					calcularPtoMedio (posCarbono, posHidrogeno);

				atomoCarbono.SetActive (false);
				atomoHidrogeno.SetActive (false);
				moleculaDeMetano.SetActive (true);
			} 
		}
		else if(condicionesNecesariasMoledulaDeAmoniaco())
		{
			Vector3 posNitrogeno = targetNitrogeno.transform.position;
			Vector3 posHidrogeno = targetHidrogeno.transform.position;

			if (distanciaMinimaParaGenerarMoledula(posNitrogeno, posHidrogeno))
			{
				moleculaDeAmoniaco.transform.position = 
					calcularPtoMedio (posNitrogeno, posHidrogeno);

				atomoNitrogeno.SetActive (false);
				atomoHidrogeno.SetActive (false);
				moleculaDeAmoniaco.SetActive (true);
			} 
		}
		else if(condicionesNecesariasMoledulaDeMonoxidoDeCarbono())
		{
			Vector3 posCarbono = targetCarbono.transform.position;
			Vector3 posOxigeno = targetOxigeno.transform.position;

			if (distanciaMinimaParaGenerarMoledula(posCarbono, posOxigeno))
			{
				moleculaDeMonoxidoDeCarbono.transform.position = 
					calcularPtoMedio (posCarbono, posOxigeno);

				atomoCarbono.SetActive (false);
				atomoOxigeno.SetActive (false);
				moleculaDeMonoxidoDeCarbono.SetActive (true);
			} 
		}
		else if(condicionesNecesariasMoledulaDeSalComun())
		{
			Vector3 posSodio = targetSodio.transform.position;
			Vector3 posCloro = targetCloro.transform.position;

			if (distanciaMinimaParaGenerarMoledula(posSodio, posCloro))
			{
				moleculaDeSalComun.transform.position = 
					calcularPtoMedio (posSodio, posCloro);

				atomoSodio.SetActive (false);
				atomoCloro.SetActive (false);
				moleculaDeSalComun.SetActive (true);
			} 
		}
		else 
		{
			moleculaDeAgua.SetActive(false);
			moleculaDeMetano.SetActive (false);
			moleculaDeAmoniaco.SetActive (false);
			moleculaDeMonoxidoDeCarbono.SetActive (false);
			moleculaDeSalComun.SetActive (false);


			atomoOxigeno.SetActive(true);
			atomoHidrogeno.SetActive(true);
			atomoCarbono.SetActive (true);
			atomoNitrogeno.SetActive (true);
			atomoSodio.SetActive (true);
			atomoCloro.SetActive (true);
		}


	}

	private bool condicionesNecesariasMoledulaDeAgua(){
		return this.isOxigeno && this.isHidrogeno;
	}
		
	private bool condicionesNecesariasMoledulaDeMetano(){
		return this.isCarbono && this.isHidrogeno;
	}

	private bool condicionesNecesariasMoledulaDeAmoniaco(){
		return this.isNitrogeno && this.isHidrogeno;
	}

	private bool condicionesNecesariasMoledulaDeMonoxidoDeCarbono(){
		return this.isCarbono && this.isOxigeno;
	}

	private bool condicionesNecesariasMoledulaDeSalComun(){
		return this.isSodio && this.isCloro;
	}

	private Vector3 calcularPtoMedio(Vector3 posTarget1, Vector3 posTarget2){

		return new Vector3(
			(posTarget1.x + posTarget2.x) / 2, 
			(posTarget1.y + posTarget2.y) / 2, 
			(posTarget1.z + posTarget2.z) / 2
		);

	}

	private bool distanciaMinimaParaGenerarMoledula(Vector3 pos1, Vector3 pos2){

		Vector3 Resultado = pos1 - pos2;

		Debug.Log(Resultado);

		return (Mathf.Abs (Resultado.x) <= 0.1f || Mathf.Abs (Resultado.y) <= 0.1f || Mathf.Abs (Resultado.z) <= 0.1f);
	}



}
