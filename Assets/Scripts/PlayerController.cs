using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float jumpPower;
    public float speed;
    [HideInInspector] public bool isGrounded;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    void FixedUpdate()
    {
        var askedToJump = Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump");

        float moveHorizontal = Input.GetAxis("Horizontal");
        if (askedToJump && isGrounded)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }

        Vector2 movement = new Vector2(moveHorizontal, 0);

        rb2d.AddForce(movement * speed);
    }
}
