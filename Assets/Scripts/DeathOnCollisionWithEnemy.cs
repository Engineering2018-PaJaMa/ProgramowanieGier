using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnCollisionWithEnemy : MonoBehaviour 
{
    public GameObject player;

    bool gameStop = false;

	// Use this for initialization
	void Start () 
    {
		
	}

    private void Update()
    {
        if(gameStop)
        {
            Application.Quit();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BodyProtoplastaTag")
        {
            Destroy(player);
            gameStop = true;
        }
    }
}
