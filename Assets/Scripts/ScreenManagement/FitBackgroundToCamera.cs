using UnityEngine;

public class FitBackgroundToCamera : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer not found on this GameObject!");
            return;
        }

        Camera cam = Camera.main;
        if (cam == null)
        {
            Debug.LogError("Main Camera not found!");
            return;
        }

        // Get the size of the sprite
        float spriteWidth = spriteRenderer.bounds.size.x;
        float spriteHeight = spriteRenderer.bounds.size.y;

        // Get the orthographic size of the camera
        float screenHeight = 2f * cam.orthographicSize;
        float screenWidth = screenHeight * Screen.width / Screen.height;

        // Adjust the scale
        transform.localScale = new Vector3(
            screenWidth / spriteWidth,
            screenHeight / spriteHeight,
            1);

        Debug.Log($"Background adjusted: New Scale = {transform.localScale}");
    }
}
