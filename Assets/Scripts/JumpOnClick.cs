using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpOnClick : MonoBehaviour {

    public float jumpForce;
    public float timeBetweenJumps;
    private float timeBetweenJumpsCount;
    private Rigidbody2D myRigidbody2D;
    private bool canJump;
    private bool isGrounded;

    // Use this for initialization
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        canJump = true;
        isGrounded = true;
        timeBetweenJumpsCount = timeBetweenJumps;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && canJump && isGrounded)
        {

            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            myRigidbody2D.AddForce(dir * jumpForce);
            canJump = true;
            isGrounded = true;

            if (!canJump)
            {
                timeBetweenJumps -= Time.deltaTime;
                if (timeBetweenJumps <= 0.0f)
                {
                    timeBetweenJumps = timeBetweenJumpsCount;
                    canJump = true;
                }
            }
        }
    }
}
