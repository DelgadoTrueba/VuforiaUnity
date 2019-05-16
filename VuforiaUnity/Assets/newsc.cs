using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newsc : MonoBehaviour {

	// Use this for initialization
	public collisionDetector controlador;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTrackingFound ()
	{
		Debug.Log("FOUNFOFUNFOUNd");	
	}

    void OnTrackingLost ()
    {
		Debug.Log("LOSTLOSTLOSTLOST");
    }
}
