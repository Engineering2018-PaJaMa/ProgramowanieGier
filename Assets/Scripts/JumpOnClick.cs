using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpOnClick : MonoBehaviour
{
    private float startTime, endTime;
    private Rigidbody2D myRigidbody2D;
    private bool canJump;
    public static bool isFlying;
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
            if (power < 800) power = 800;
            if (power > 3000) power = 3000;
            print(power);
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            myRigidbody2D.AddForce(dir * power);
            canJump = false;
            isFlying = true;

        }
    }
}
