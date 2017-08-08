using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGameController : MonoBehaviour {
    private LevelManager levelManager;
    public GameObject pauseMenu;

    void Awake()
    {
        levelManager = GetComponent<LevelManager>();
    }

    void Start()
    {
        pauseMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
        var canPause = (levelManager.isGameOver == false && levelManager.isLevelComplete == false);

        if (Input.GetButtonDown(Buttons.Pause) && canPause)
        {
            TogglePause();
        }

        if (levelManager.isPaused)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }


    public void Pause()
    {
        levelManager.isPaused = true;
    }

    public void Unpause()
    {
        levelManager.isPaused = false;
    }

    public void TogglePause()
    {
        levelManager.isPaused = !levelManager.isPaused;
    }
}
