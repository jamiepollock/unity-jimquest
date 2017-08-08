using UnityEngine;

public class LevelUIController : MonoBehaviour {
    public GameObject levelUIPrefab;
    private LevelManager levelManager;
    
    void Awake()
    {
        levelManager = GetComponent<LevelManager>();
    }

    // Use this for initialization
    void Start () {
        Instantiate(levelUIPrefab, levelManager.transform);
	}
}
