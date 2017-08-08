using UnityEngine;

public class LevelCompleteController : MonoBehaviour {
    public GameObject levelCompleteMenuPrefab;
    private GameObject levelCompleteMenu;
    private LevelManager levelManager;

    void Awake()
    {
        levelManager = GetComponent<LevelManager>();
    }

    void Start()
    {
        levelCompleteMenu = Instantiate(levelCompleteMenuPrefab, levelManager.gameObject.transform);
        levelCompleteMenu.name = "Level Complete Menu";

        levelCompleteMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (levelManager.exit.isReached && levelManager.isLevelComplete == false)
        {
            levelManager.isLevelComplete = true;
            levelManager.player.gameObject.SetActive(false);

            levelCompleteMenu.SetActive(true);
        }
    }
}
