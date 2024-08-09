using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene("GameOverScene"); // Load the Game Over scene
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace "YourGameSceneName" with the actual name of your game scene
    }
}
