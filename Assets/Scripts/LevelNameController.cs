using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelNameController : MonoBehaviour {
    private LevelManager levelManager;
    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        levelManager = GetComponentInParent<LevelManager>();
    }

    void Start () {
        string levelName;

        if (string.IsNullOrEmpty(levelManager.levelName) == false) {
            levelName = string.Format("{0}: {1}", GetDefaultLevelName(), levelManager.levelName);
        } else
        {
            levelName = GetDefaultLevelName();
        }

        text.text = levelName;
    }

    private string GetDefaultLevelName()
    {
        return string.Format("Level {0}", SceneManager.GetActiveScene().buildIndex);
    }
}
