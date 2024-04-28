using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f; // Speed of player movement

    void Update()
    {
        // Move right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Move(Vector3.right);
        }
        // Move left
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Move(Vector3.left);
        }
        // Move forward
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Move(Vector3.forward);
        }
        // Move backward
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Move(Vector3.back);
        }
    }

    // Move function to move the player in the specified direction
    void Move(Vector3 direction)
    {
        transform.Translate(direction * moveSpeed);
    }
}
