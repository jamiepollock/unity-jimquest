using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuItemNextLevelController : MonoBehaviour {
    private LevelManager levelManager;
    private Button button;
    private bool hasNextLevel;

    void Awake()
    {
        levelManager = GetComponentInParent<LevelManager>();

        hasNextLevel = levelManager.nextLevelBuildIndex > -1;

        gameObject.SetActive(hasNextLevel);
    }

    void Start () {
        if (hasNextLevel)
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(new UnityAction(() => levelManager.LoadNextLevel()));
        }
    }
}
