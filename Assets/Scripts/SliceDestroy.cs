using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceDestroy : MonoBehaviour {

    public GameObject entityToDestoy;
    public Text pointsToShow;

    static int points = 0;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        pointsToShow.text = "Points: " + points.ToString();
    }
    
    void OnMouseOver()
    {
        points = points + 1;
        Destroy(entityToDestoy);
    }
}
