using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KillPlayerController : MonoBehaviour {

    private PlayerController player;

    private void Awake()
    {
        player = GetComponentInParent<LevelManager>().player;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player.gameObject)
        {
            player.isDead = true;

        }
    }
}
