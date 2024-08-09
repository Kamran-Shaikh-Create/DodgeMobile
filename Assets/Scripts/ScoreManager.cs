using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float score = 0;

    void Update()
    {
        score += Time.deltaTime;
        if (scoreText != null)
        {
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
        else
        {
            Debug.LogError("Score Text is not assigned in the Inspector.");
        }
    }

    public void EndGame()
    {
        int finalScore = Mathf.FloorToInt(score);
        ScoreManagerData.Instance.FinalScore = finalScore;
        Debug.Log("EndGame called. Final Score set in ScoreManagerData: " + finalScore);

        SceneManager.LoadScene("GameOverScene");
    }
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        if (scoreText == null)
        {
            Debug.LogError("Score Text not found.");
        }
    }
}
