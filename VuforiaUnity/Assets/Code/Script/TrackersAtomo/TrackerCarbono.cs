using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*add vuforia*/
using Vuforia;

public class TrackerCarbono : MonoBehaviour, ITrackableEventHandler {

	private TrackableBehaviour mTrackableBehaviour;

	public GameObject controladorMoleculas;

	void Start () {

		mTrackableBehaviour = GetComponent<TrackableBehaviour> ();

		if (mTrackableBehaviour) {
			mTrackableBehaviour.RegisterTrackableEventHandler (this);
		}		
	}


	void Update () {

	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			OnTrackingFound();
		}
		else
		{
			OnTrackingLost();
		}
	}

	private void OnTrackingFound()
	{
		Debug.Log ("Carbono: Hola");
		controladorMoleculas.GetComponent<ControladorMoleculas> ().isCarbono = true;
	}
	private void OnTrackingLost()
	{
		Debug.Log ("Carbono: Adios");
		controladorMoleculas.GetComponent<ControladorMoleculas> ().isCarbono = false;
	}
}
