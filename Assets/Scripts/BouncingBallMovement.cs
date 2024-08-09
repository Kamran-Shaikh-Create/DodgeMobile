using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float initialSpeed = 5f;
    public float speedIncreaseFactor = 1.2f;
    public float speedIncreaseInterval = 20f;

    private Rigidbody2D rb;
    private float timeSinceLastIncrease;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Set an initial random direction for the ball
        Vector2 initialDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.velocity = initialDirection * initialSpeed;
        timeSinceLastIncrease = 0f;
    }

    void Update()
    {
        // Track time for speed increase
        timeSinceLastIncrease += Time.deltaTime;

        // Increase speed at regular intervals
        if (timeSinceLastIncrease >= speedIncreaseInterval)
        {
            rb.velocity *= speedIncreaseFactor;
            timeSinceLastIncrease = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reflect the velocity based on the collision normal
        Vector2 reflectedVelocity = Vector2.Reflect(rb.velocity, collision.contacts[0].normal);
        rb.velocity = reflectedVelocity.normalized * rb.velocity.magnitude; // Ensure the speed remains constant
    }
}
