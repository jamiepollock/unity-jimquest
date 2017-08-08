using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelectionController : MonoBehaviour
{
    private Button selectedObject;
    private bool buttonSelected;
    private LevelManager levelManager;

    void Awake()
    {
        levelManager = GetComponentInParent<LevelManager>();
    }

    void Start()
    {
        var buttons = GetComponentsInChildren<Button>();

        if (buttons.Any(x => x.isActiveAndEnabled))
        {
            selectedObject = buttons.First(x => x.isActiveAndEnabled);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") != 0 && buttonSelected == false)
        {
            levelManager.menusEventSystem.SetSelectedGameObject(selectedObject.gameObject);
            buttonSelected = true;
        }
    }

    private void OnDisable()
    {
        buttonSelected = false;
    }
}