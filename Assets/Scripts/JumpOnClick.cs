using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpOnClick : MonoBehaviour
{
    private float startTime, endTime;
    private Rigidbody2D myRigidbody2D;
    private bool canJump;
    public static bool isFlying = false;
    public Text pointsToShow;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        canJump = true;
        isFlying = false;
        startTime = 0f;
        endTime = 0f;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            startTime = Time.time;
        }

        if (Input.GetMouseButtonUp(0) && canJump)
        {
            endTime = Time.time;
            float power = (endTime - startTime) * 1000f;
            if (power < 2000) power = 2000;
            if (power > 4000) power = 4000;
            print(power);
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            if (angle > 90) 
            {
                angle = 80;
            }

            if (angle <0) {
                angle = 10;
            }

            Vector2 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            print(angle);

            myRigidbody2D.AddForce(dir * power);
            canJump = false;
            isFlying = true;

        }
    }
}
