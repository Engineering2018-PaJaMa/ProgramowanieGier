using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BodyProtoplastaTag")
        {
            Destroy(player);
            DataController.playerHp -= 1;
            JumpOnClick.isFlying = false;
            SceneManager.LoadScene("Menu Scene");
            SliceDestroy.points = 0;
        }
    }
}
