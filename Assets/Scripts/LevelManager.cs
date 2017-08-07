using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public PlayerController player;
    public ExitController exit;
    public int nextLevelBuildIndex = -1;

    [HideInInspector] public bool isGameOver;
    [HideInInspector] public bool isLevelComplete;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && isLevelComplete)
        {
            SceneManager.LoadScene(nextLevelBuildIndex);
        }
    }
}
