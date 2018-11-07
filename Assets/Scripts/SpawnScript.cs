using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject enemy;
    public GameObject player;
    public float spawnRate = 2f;

    float randX;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;

    float playerPositionX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerPositionX = player.transform.position.x;

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(playerPositionX, playerPositionX + 10f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
	}
}
