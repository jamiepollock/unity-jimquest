using UnityEngine;

public class PauseGameController : MonoBehaviour {
    public GameObject pauseMenuPrefab;
    private GameObject pauseMenu;
    private LevelManager levelManager;

    void Awake()
    {
        levelManager = GetComponent<LevelManager>();
    }

    void Start()
    {
        pauseMenu = Instantiate(pauseMenuPrefab, levelManager.gameObject.transform);
        pauseMenu.name = "Pause Menu";
        pauseMenu.SetActive(false);
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
