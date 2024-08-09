using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenuCanvas;

    void Update()
    {
        // Toggle pause menu with a button press or gesture
        if (Input.GetKeyDown(KeyCode.Escape)) // You can change this to any key or gesture
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        if (pauseMenuCanvas != null)
        {
            bool isActive = pauseMenuCanvas.activeSelf;
            pauseMenuCanvas.SetActive(!isActive);

            // Pause or resume the game
            Time.timeScale = isActive ? 1 : 0;
        }
    }

    public void OnProceedToMainMenu()
    {
        Time.timeScale = 1; // Ensure time is running when returning to the main menu
        SceneManager.LoadScene("MainMenuScene"); // Replace with your main menu scene name
    }

    public void OnClosePauseMenu()
    {
        TogglePauseMenu(); // Close the pause menu
    }

    public void OnQuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop play mode in the editor
#else
        Application.Quit(); // Quit the game in a built version
#endif
    }
}
