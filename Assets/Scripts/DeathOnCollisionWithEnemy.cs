using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnCollisionWithEnemy : MonoBehaviour 
{
    public GameObject player;
    public GameObject enemyOnCloud;
    public GameObject fatEnemy;

	// Use this for initialization
	void Start () 
    {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BodyProtoplastaTag")
        {
            Destroy(player);
            Application.Quit();
        }
    }
}
