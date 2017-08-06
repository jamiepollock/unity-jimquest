using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckController : MonoBehaviour {
    public PlayerController player;

	// Use this for initialization
	void Start () {
	}
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        //if (transform.position.y < collision.otherCollider.transform.position.y)
        //{
        //if (collision.CompareTag("GroundZone"))
        //{
            player.isGrounded = true;
        //}
        //}
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        player.isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        player.isGrounded = false;
    }
}
