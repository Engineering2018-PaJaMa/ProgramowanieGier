using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCloud : MonoBehaviour {
    public GameObject cloud;
    public GameObject player;
    public GameObject yellowClouds;
    public float spawnRate = 2f;
    public static bool yellowCloud = false;

    float randX;
    float randY;
    Vector2 whereToSpawn;
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
            randX = Random.Range(playerPositionX + 15f, playerPositionX + 30f);
            randY = Random.Range(playerPositionY - 5f, playerPositionY + 20f);
            whereToSpawn = new Vector2(randX, randY);
            if (yellowCloud)
            {
                Instantiate(yellowClouds, whereToSpawn, Quaternion.identity);
            }
            else
            {
                Instantiate(cloud, whereToSpawn, Quaternion.identity);
            }
        }
    }
}
