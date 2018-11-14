using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {

    public GameObject cloud;
    public GameObject player;
    public float spawnRate = 2f;

    float randX;
    float randY;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;

    float playerPositionX;
    float playerPositionY;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        playerPositionX = player.transform.position.x;
        playerPositionY = player.transform.position.y;

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(playerPositionX + 5f, playerPositionX + 30f);
            randY = Random.Range(playerPositionY -5f, playerPositionY + 30f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(cloud, whereToSpawn, Quaternion.identity);
        }
    }
}
