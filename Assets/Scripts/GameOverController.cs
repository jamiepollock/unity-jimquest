using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour {
    public GameObject gameOverMenuPrefab;
    private GameObject gameOverMenu;

    private PlayerController player;
    private LevelManager levelManager;

    void Awake()
    {
        levelManager = GetComponent<LevelManager>();
        gameOverMenu = Instantiate(gameOverMenuPrefab, levelManager.gameObject.transform);
        gameOverMenu.name = "Game Over Menu";

        player = levelManager.player;
        
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		if (player.isDead && levelManager.isGameOver == false)
        {
            levelManager.isGameOver = true;
            player.gameObject.SetActive(false);

            gameOverMenu.SetActive(true);
        }
	}
}
