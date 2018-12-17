using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Initialize : MonoBehaviour {

    string gameID = "2951672";
    bool testMode = true;
    
    // Use this for initialization
    void Start () {
        Advertisement.Initialize(gameID, testMode);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
