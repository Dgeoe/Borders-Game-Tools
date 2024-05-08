using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject buttonObject1; // Reference to the first Button with the Button script
    public GameObject buttonObject2; // Reference to the second Button with the Button script
    public Collider player1Collider; // Collider for 1st player to enter (check if infront of door)
    public Collider player2Collider; // Collider for 2nd player to enter (check if infront of door)
    public Collider colliderToDisable; // Collider to be disabled (Tile w/restriction where door is placed)

    private Button buttonScript1; // Reference to the Button script on the first button
    private Button buttonScript2; // Reference to the Button script on the second button

    private void Start()
    {
        // Getting the Button script components from the specified GameObjects
        buttonScript1 = buttonObject1.GetComponent<Button>();
        buttonScript2 = buttonObject2.GetComponent<Button>();
    }

    private void Update()
    {
        // Checking if all conditions are met to disable the collider
        if (buttonScript1.playerInside && buttonScript2.playerInside && PlayerInsideCollider(player1Collider) && PlayerInsideCollider(player2Collider))
        {
            // All conditions are met, disable the collider
            colliderToDisable.enabled = false;
            Debug.Log("Door collider disabled.");
        }
    }

    // Function to check if a player is inside a collider (infront of door)
    private bool PlayerInsideCollider(Collider playerCollider)
    {
        return playerCollider.bounds.Contains(playerCollider.transform.position);
    }
}