using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour {
    public GameObject enemy;
    public GameObject player;
    public float spawnRate = 2f;

    Vector2 whereToSpawn;
    float randX;
    float randY;
    float nextSpawn = 0.0f;
    float playerPositionX;
    float playerPositionY;
    float playerStartingPositionX;

	// Use this for initialization
	void Start () {
        playerStartingPositionX = player.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        playerPositionX = player.transform.position.x;
        playerPositionY = player.transform.position.y;

        if (Time.time > nextSpawn && playerPositionX > playerStartingPositionX)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(playerPositionX + 35f, playerPositionX +50f);
            randY = Random.Range(playerPositionY + 5f, playerPositionY + 10f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
	}
}
