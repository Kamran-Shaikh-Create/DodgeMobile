using UnityEngine;

public class ScoreManagerData : MonoBehaviour
{
    public static ScoreManagerData Instance { get; private set; }
    public int FinalScore { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("ScoreManagerData instance created.");
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Duplicate ScoreManagerData instance destroyed.");
        }
    }


}
