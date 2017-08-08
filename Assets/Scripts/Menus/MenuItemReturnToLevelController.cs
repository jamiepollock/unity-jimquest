using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuItemReturnToLevelController : MonoBehaviour {

    private PauseGameController pauseGameController;
    private Button button;
	// Use this for initialization
	void Start () {
        pauseGameController = GetComponentInParent<PauseGameController>();

        button = GetComponent<Button>();
        button.onClick.AddListener(new UnityAction(() => pauseGameController.Unpause()));
	}
}
