using UnityEngine;

public class Pipes : MonoBehaviour
{
    // Speed at which the pipes move to the left
    public float speed = 5f;

    // The x-position (world space) where the pipes should be destroyed
    private float leftEdge;

    private void Start()
    {
        // Calculate the left edge of the screen in world coordinates
        // Vector3.zero represents the bottom-left corner of the screen in screen space (0, 0)
        // ScreenToWorldPoint converts this to world space coordinates
        // Subtracting 1f ensures the pipes are destroyed slightly off-screen *fully outside of the screen*
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        // Move the pipes to the left at a constant speed
        // Vector3.left represents movement along the negative x-axis
        // Time.deltaTime ensures the movement is frame-rate independent
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Check if the pipes have moved past the left edge of the screen
        if (transform.position.x < leftEdge)
        {
            // Destroy the pipes GameObject to free up memory
            Destroy(gameObject);
        }
    }
}
