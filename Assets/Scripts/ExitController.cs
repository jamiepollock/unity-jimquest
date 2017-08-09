using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    [HideInInspector] public bool isReached;

    private PlayerController player;
    private AudioSource clip;
    private void Awake()
    {
        clip = GetComponent<AudioSource>();
        player = GetComponentInParent<LevelManager>().player;
    }

    void Start()
    {
        isReached = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player.gameObject)
        {
            isReached = true;
            clip.Play();
        }
    }

}
