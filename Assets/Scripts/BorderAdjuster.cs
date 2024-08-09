using UnityEngine;

public class BorderAdjuster : MonoBehaviour
{
    public RectTransform borderRectTransform; // Reference to the RectTransform of the border
    public float aspectRatioWidth = 16.0f;    // Desired aspect ratio width
    public float aspectRatioHeight = 9.0f;    // Desired aspect ratio height

    void Start()
    {
        AdjustBorder();
    }

    void AdjustBorder()
    {
        // Calculate the current screen aspect ratio
        float screenAspect = (float)Screen.width / Screen.height;

        // Calculate the desired aspect ratio
        float desiredAspect = aspectRatioWidth / aspectRatioHeight;

        // Determine the border size based on aspect ratios
        if (screenAspect >= desiredAspect)
        {
            // Screen is wider than desired aspect ratio
            float width = Screen.height * desiredAspect;
            float height = Screen.height;
            borderRectTransform.sizeDelta = new Vector2(width, height);
        }
        else
        {
            // Screen is taller than desired aspect ratio
            float width = Screen.width;
            float height = Screen.width / desiredAspect;
            borderRectTransform.sizeDelta = new Vector2(width, height);
        }

        // Center the border on the screen
        borderRectTransform.anchoredPosition = Vector2.zero;
    }
}
