using UnityEngine;

public class Treadmill : MonoBehaviour
{
    public enum Direction { Forward, Backward, Left, Right };
    public Direction direction = Direction.Forward;

    public float forceMagnitude = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Apply force based on the selected direction
            ApplyForce(other.attachedRigidbody);
        }
    }

    private void ApplyForce(Rigidbody2D rb)
    {
        Vector2 forceDirection = Vector2.zero;

        // Determine the force direction based on the selected direction
        switch (direction)
        {
            case Direction.Forward:
                forceDirection = Vector2.up;
                break;
            case Direction.Backward:
                forceDirection = Vector2.down;
                break;
            case Direction.Left:
                forceDirection = Vector2.left;
                break;
            case Direction.Right:
                forceDirection = Vector2.right;
                break;
        }

        // Apply force to the player rigidbody
        rb.AddForce(forceDirection * forceMagnitude, ForceMode2D.Impulse);
    }
}
