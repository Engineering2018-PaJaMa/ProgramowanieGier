using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowBackground : MonoBehaviour 
{
    private GameObject wayPoint;    ///You may consider adding a rigid body to the zombie for accurate physics simulation
    private Vector3 wayPointPos;
    private float speed = 100.0f;   //This will be the zombie's speed. Adjust as necessary.
    void Start()
    {
        //At the start of the game, the zombies will find the gameobject called wayPoint.
        wayPoint = GameObject.Find("wayPoint");
    }

    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
        //Here, the zombie's will follow the waypoint.
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    }
}
