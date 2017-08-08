using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public EventSystem menusEventSystem;
    public PlayerController player;
    public ExitController exit;
    public int nextLevelBuildIndex = -1;

    [HideInInspector] public bool isGameOver;
    [HideInInspector] public bool isLevelComplete;
    [HideInInspector] public bool isPaused;

    internal void LoadNextLevel()
    {
        if (nextLevelBuildIndex > -1)
        {
            SceneManager.LoadScene(nextLevelBuildIndex);
        }
    }
}
