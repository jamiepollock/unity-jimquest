using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuItemNextLevelController : MonoBehaviour {
    private Button button;
    private bool hasNextLevel;
    private int nextSceneBuildIndex;

    void Awake()
    {
        nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
        hasNextLevel = nextSceneBuildIndex < SceneManager.sceneCountInBuildSettings;

        gameObject.SetActive(hasNextLevel);
    }

    void Start () {
        if (hasNextLevel)
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(new UnityAction(() => SceneManager.LoadScene(nextSceneBuildIndex)));
        }
    }
}
