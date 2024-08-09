using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Make sure to use the exact name of your game scene
    }

    public void QuitGame()
    {
        // Quits the game when built. This will not work in the editor.
        Application.Quit();

        // If you want to test quitting in the editor, you can use:
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
