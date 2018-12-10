using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceDestroy : MonoBehaviour {

    public GameObject entityToDestoy;
    public GameObject player;
    public Text pointsToShow;

    public static float points = 0;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (JumpOnClick.isFlying) {
            points += 0.01f;
        }
        pointsToShow.text = "Points: " + Mathf.Round(points).ToString();
        if (points >10)
        {
            SpawnerCloud.yellowCloud = true;
            SpawnerEnemy.enemyRespawn2 = true;
        }

    }
    
    void OnMouseOver()
    {
        points = points + 10;
        Destroy(entityToDestoy);
    }
}
