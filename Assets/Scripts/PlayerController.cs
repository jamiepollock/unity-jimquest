using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float jumpPower;
    public float speed;
    private bool groundCheck;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        groundCheck = false;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb2d.AddForce(movement * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        groundCheck = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        groundCheck = false;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        groundCheck = true;
    }
}
