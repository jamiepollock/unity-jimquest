using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public EventSystem menusEventSystem;
    public PlayerController player;
    public ExitController exit;
    public string levelName;

    [HideInInspector] public bool isGameOver;
    [HideInInspector] public bool isLevelComplete;
    [HideInInspector] public bool isPaused;
}
