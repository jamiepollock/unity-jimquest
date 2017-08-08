using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuItemExitGameController : MonoBehaviour {

    private ExitGameController exitGameController;
    private Button button;

    void Start()
    {
        exitGameController = GetComponentInParent<ExitGameController>();

        button = GetComponent<Button>();
        button.onClick.AddListener(new UnityAction(() => exitGameController.ExitGame()));
    }
}
