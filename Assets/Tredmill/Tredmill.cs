using UnityEngine;

public class Treadmill : MonoBehaviour
{
    public enum Direction { Forward, Backward, Left, Right };
    public Direction movementDirection = Direction.Forward;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Move the player 
            MovePlayer(other.transform);
        }
    }

    private void MovePlayer(Transform playerTransform)
    {
        Vector3 movementVector = Vector3.zero;

        switch (movementDirection)
        {
            case Direction.Forward:
                movementVector = Vector3.forward;
                break;
            case Direction.Backward:
                movementVector = Vector3.back;
                break;
            case Direction.Left:
                movementVector = Vector3.left;
                break;
            case Direction.Right:
                movementVector = Vector3.right;
                break;
        }

        // Move the player in direction of arrow on treadmill
        playerTransform.Translate(movementVector);
    }
} 