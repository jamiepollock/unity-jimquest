using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGameController : MonoBehaviour {

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void ExitToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }
}
