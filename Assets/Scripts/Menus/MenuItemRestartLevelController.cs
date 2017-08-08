using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuItemRestartLevelController : MonoBehaviour {

    private RestartLevelController restartLevelController;
    private Button button;

    void Start()
    {
        restartLevelController = GetComponentInParent<RestartLevelController>();

        button = GetComponent<Button>();
        button.onClick.AddListener(new UnityAction(() => restartLevelController.RestartLevel()));
    }
}
