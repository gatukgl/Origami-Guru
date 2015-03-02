using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class TrackableList : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// Get the StateManager
		StateManager sm = TrackerManager.Instance.GetStateManager ();
		
		// Query the StateManager to retrieve the list of
		// currently 'active' trackables 
		//(i.e. the ones currently being tracked by Vuforia)
		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
		
		// Iterate through the list of active trackables
		Debug.Log ("List of trackables currently active (tracked): ");
		int numFrameMarkers = 0;
		int numImageTargets = 0;
		int numMultiTargets = 0;
		foreach (TrackableBehaviour tb in activeTrackables) {
			Debug.Log("Trackable: " + tb.TrackableName);
			
			if (tb is MarkerBehaviour)
				numFrameMarkers++;
			else if (tb is ImageTargetBehaviour)
				numImageTargets++;
			else if (tb is MultiTargetBehaviour)
				numMultiTargets++;
		}
		
		Debug.Log ("Found " + numFrameMarkers + " frame markers in curent frame");
		Debug.Log ("Found " + numImageTargets + " image targets in curent frame");
		Debug.Log ("Found " + numMultiTargets + " multi-targets in curent frame");
	}
}
