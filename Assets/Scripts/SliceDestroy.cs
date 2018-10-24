using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceDestroy : MonoBehaviour {

    public GameObject entityToDestoy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    
    private void OnMouseOver()
    {
        Destroy(entityToDestoy);
    }
}
