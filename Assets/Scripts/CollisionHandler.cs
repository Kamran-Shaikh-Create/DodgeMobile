using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BouncingBall"))
        {
            Debug.Log("Collision detected with BouncingBall.");

            // Find the ScoreManager instance and call EndGame
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.EndGame();
            }
            else
            {
                Debug.LogError("ScoreManager instance not found.");
            }
        }
    }
}
