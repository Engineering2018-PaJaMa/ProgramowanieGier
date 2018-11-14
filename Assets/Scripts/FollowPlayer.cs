using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
    // Use this for initialization.
    // In the editor, add your wayPoint gameobject to the script.
    // This is how often your waypoint's position will update to the player's position.
    public GameObject wayPoint;     

    void Update()
    {
        UpdatePosition();
    }

    void UpdatePosition()
    {
        //The wayPoint's position will now be the player's current position.
        wayPoint.transform.position = transform.position;
    }
}
