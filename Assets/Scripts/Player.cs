using UnityEngine;

public class Player : MonoBehaviour
{
    // Direction vector to control the player's movement
    private Vector3 direction;

    // Sprite Renderer for visualizing the bird's movement
    private SpriteRenderer spriteRenderer;

    // Array of sprites for animation
    public Sprite[] sprites;

    // Index for cycling through the sprite animation
    private int spriteIndex;

    // Gravity value to simulate downward force
    public float gravity = -9.8f;

    // Strength of the bird's upward movement (flap)
    public float strength = 5f;

    private void Awake()
    {
        // Get the SpriteRenderer component attached to the GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        // Start animating the sprite repeatedly every 0.15 seconds
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }
    private void OnEnable(){
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    private void Update()
    {
        // Check for player input (spacebar or mouse click)
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // Apply upward force to move the bird
            direction = Vector3.up * strength;
        }

        // Check for touch input (for mobile devices)
        if (Input.touchCount > 0)
        {
            // Get the first touch
            Touch touch = Input.GetTouch(0);

            // If the touch has just started
            if (touch.phase == TouchPhase.Began)
            {
                // Apply upward force to move the bird
                direction = Vector3.up * strength;
            }
        }

        // Apply gravity to the bird's movement
        direction.y += gravity * Time.deltaTime;

        // Update the bird's position on the screen
        transform.position += direction * Time.deltaTime;
    }

    private void AnimateSprite()
    {
        // Increment the sprite index for animation
        spriteIndex++;

        // Reset the index if it exceeds the array length
        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        // Update the bird's sprite to the current frame
        spriteRenderer.sprite = sprites[spriteIndex];
    }
    //"This method is outdated-מיושנת
    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Obstacle"){
            //search over all the scenes for the object not the best approach.
            FindObjectOfType<GameManager>().GameOver();
        } else if(other.gameObject.tag == "Scoring"){
            FindObjectOfType<GameManager>().IncreaseScore();
        }
        
    }
}
