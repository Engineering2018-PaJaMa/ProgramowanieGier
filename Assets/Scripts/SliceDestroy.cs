using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceDestroy : MonoBehaviour {

    public GameObject entityToDestoy;
    public GameObject player;
    public Text pointsToShow;

    static float points = 0;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        pointsToShow.text = "Points: " + points.ToString();
    }
    
    void OnMouseOver()
    {
        points = points + 10;
        Destroy(entityToDestoy);
    }
}
