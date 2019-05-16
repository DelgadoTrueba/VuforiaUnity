using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*add vuforia*/
using Vuforia;

public class TrackerNitrogeno : MonoBehaviour, ITrackableEventHandler {

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
		Debug.Log ("Hidrogeno: Hola");
		controladorMoleculas.GetComponent<ControladorMoleculas> ().isNitrogeno = true;
	}
	private void OnTrackingLost()
	{
		Debug.Log ("Hidrogeno: Adios");
		controladorMoleculas.GetComponent<ControladorMoleculas> ().isNitrogeno = false;
	}
}
