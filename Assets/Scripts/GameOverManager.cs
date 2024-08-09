using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    void Start()
    {
        int finalScore = ScoreManagerData.Instance.FinalScore;
        Debug.Log("Start called. Final Score retrieved from ScoreManagerData: " + finalScore);

        if (finalScoreText != null)
        {
            finalScoreText.text = "Final Score: " + finalScore.ToString();
        }
        else
        {
            Debug.LogError("FinalScoreText is not assigned.");
        }
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
