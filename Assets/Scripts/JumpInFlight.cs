using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpInFlight : MonoBehaviour {

    public GameObject player;
    public Button jumpButton;

    private Rigidbody2D playerRigidBody2D;
    private Vector2 jumpVector = new Vector2(0, 1000);

    private float interval;
    private float lastJump, newJump;

    // Use this for initialization
    void Start () {
        playerRigidBody2D = player.GetComponent<Rigidbody2D>();
        lastJump = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        newJump = Time.time;
        interval = newJump - lastJump;

        if(interval < 3) {
            jumpButton.interactable = false;
        }
        else {
            jumpButton.interactable = true;
        }
    }

    public void Jump() {
        if(interval > 3) {
            playerRigidBody2D.AddForce(jumpVector);
            lastJump = Time.time;
        }
    }
}
