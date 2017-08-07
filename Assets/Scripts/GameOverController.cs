using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {
    public Text gameOverText;

    private PlayerController player;
    private LevelManager levelManager;

    void Awake()
    {
        levelManager = GetComponent<LevelManager>();
        player = levelManager.player;

        if (gameOverText != null)
        {
            gameOverText.enabled = false;
        }
    }

    // Update is called once per frame
    void Update () {
		if (player.isDead && levelManager.isGameOver == false)
        {
            levelManager.isGameOver = true;
            player.gameObject.SetActive(false);

            if (gameOverText != null)
            {
                gameOverText.enabled = true;
            }
            Debug.Log("player is dead");
        }
	}
}
