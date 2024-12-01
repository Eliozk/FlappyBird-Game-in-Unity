using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Prefab to spawn (e.g., pipes or obstacles in the game)
    public GameObject prefab;

    // Rate at which objects will be spawned (in seconds)
    public float spawnRate = 1f;

    // Minimum height at which the object can spawn
    public float minHeight = -1f;

    // Maximum height at which the object can spawn
    public float maxHeight = 1f;

    private void OnEnable()
    {
        // Start invoking the Spawn method repeatedly at the specified spawnRate interval
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        // Stop invoking the Spawn method when the spawner is disabled
        CancelInvoke(nameof(Spawn));
    }
    /// <summary>
    /// Spawns a new instance of the prefab (e.g., pipes or obstacles) at the spawner's position.
    /// Adjusts the vertical position of the spawned object to a random height within the specified range
    /// (minHeight to maxHeight) for dynamic gameplay.
    /// </summary>
    private void Spawn()
    {
        // Create a new instance of the prefab (e.g., pipes) at the spawner's position
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);

        // Adjust the position of the newly spawned object (pipes)
        // Add a vertical offset within the range of minHeight to maxHeight
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
