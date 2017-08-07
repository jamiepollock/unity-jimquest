﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitController : MonoBehaviour
{
    [HideInInspector] public bool isReached;

    private PlayerController player;

    private void Awake()
    {
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
        }
    }

}
