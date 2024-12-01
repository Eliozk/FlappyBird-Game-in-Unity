using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Reference to the Player script to control the player's state
    public Player player;

    // UI Text to display the score
    public Text scoreText;

    // Button to start or restart the game
    public GameObject playButton;

    // UI element to display the "Game Over" message
    public GameObject gameOver;

    // Tracks the current score of the player
    private int score;

    private void Awake()
    {
        // Sets the frame rate to a consistent 60 FPS
        Application.targetFrameRate = 60;

        // Pauses the game at the start
        Pause();
    }

    [System.Obsolete]
    public void Play()
    {
        // Reset the score to 0 when the game starts
        score = 0;

        // Update the score text in the UI
        scoreText.text = score.ToString();

        // Hide the play button and "Game Over" UI when the game starts
        playButton.SetActive(false);
        gameOver.SetActive(false);

        // Resume game time and enable the player
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for(int i = 0 ; i < pipes.Length ; i++){
            Destroy(pipes[i].gameObject);
        }
        
    }

    public void Pause()
    {
        // Pauses the game by stopping the time scale
        // This also prevents any time-based events from progressing
        Time.timeScale = 0f;

        // Disable the player's ability to move while the game is paused
        player.enabled = false;
    }

    public void GameOver()
    {
        // Called when the player loses the game
        Debug.Log("Game Over"); // Log the game over event for debugging

        // Show the "Game Over" UI
        gameOver.SetActive(true);

        // Show the play button to allow restarting the game
        playButton.SetActive(true);

        // Pause the game to stop all activity
        Pause();
    }

    public void IncreaseScore()
    {
        // Increment the score when the player passes an obstacle
        Debug.Log("Scoring"); // Log the scoring event for debugging
        score++;

        // Update the score text in the UI
        scoreText.text = score.ToString();
    }
}
