using UnityEngine;

public class Parallax : MonoBehaviour
{
    // Reference to the MeshRenderer component for accessing the material
    private MeshRenderer meshRenderer;

    // Speed of the parallax effect (how fast the background moves)
    public float animationSpeed = 0.1f;

    private void Awake()
    {
        // Get the MeshRenderer component attached to this GameObject
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        // Move the texture by updating the main texture's offset
        meshRenderer.material.mainTextureOffset += new Vector2(
            animationSpeed * Time.deltaTime, // Horizontal movement based on speed and time
            0);                             // No vertical movement
    }
}
