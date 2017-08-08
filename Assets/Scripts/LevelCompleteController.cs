using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteController : MonoBehaviour {
    public Text levelCompleteText;
    private LevelManager levelManager;
    void Awake()
    {
        levelManager = GetComponent<LevelManager>();
        levelCompleteText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (levelManager.exit.isReached && levelManager.isLevelComplete == false)
        {
            levelManager.isLevelComplete = true;
            levelManager.player.gameObject.SetActive(false);
            levelCompleteText.enabled = true;
        }
    }
}
