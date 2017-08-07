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
    
    public Scene GetNextLevel()
    {

        if (nextLevelBuildIndex > -1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextLevelBuildIndex, LoadSceneMode.Additive);

            UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(nextLevelBuildIndex);
        }

        return new Scene();
    }
}
