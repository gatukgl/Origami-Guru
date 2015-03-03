using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using Vuforia;

public class TrackableList : MonoBehaviour {
	private DataSet mDataset = null;
	//StateManager sm = TrackerManager.Instance.GetStateManager();
	IEnumerable<TrackableBehaviour> tbs = TrackerManager.Instance.GetStateManager().GetTrackableBehaviours();

	void start() {
		Debug.Log("TrackableList is called!!!!");
		if(tbs != null){
			Debug.Log("The trackable list is not null");
		}


	}

	// Update is called once per frame
	void Update () {
		foreach(TrackableBehaviour tb in tbs)
		{
			string name = tb.TrackableName;
			//ImageTarget it = tb.Trackable as ImageTarget;
			//int n_trackable = mDataset.GetNumTrackables();
			
			//Debug.Log("the number of trackable in dataset = " + n_trackable);
			Debug.Log("Active image target in dataset list = " + name + "   ,  ");
		}
	}
}
