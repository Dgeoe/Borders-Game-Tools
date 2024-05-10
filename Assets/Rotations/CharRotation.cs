using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Animator animator;
    public bool inverse  = false;

    void Start()
    {
        // Get the Animator component attached to the character
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for input from the arrow keys
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Trigger the animation for moving left
            animator.SetTrigger("A");

            // Reset other triggers
            ResetOtherTriggers("A");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && inverse)
        {
            // Trigger the animation for moving left
            animator.SetTrigger("D");

            // Reset other triggers
            ResetOtherTriggers("D");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Trigger the animation for moving right
            animator.SetTrigger("D");

            // Reset other triggers
            ResetOtherTriggers("D");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && inverse)
        {
            // Trigger the animation for moving right
            animator.SetTrigger("A");

            // Reset other triggers
            ResetOtherTriggers("A");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Trigger the animation for moving down
            animator.SetTrigger("S");

            // Reset other triggers
            ResetOtherTriggers("S");
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Trigger the animation for moving up
            animator.SetTrigger("W");

            // Reset other triggers
            ResetOtherTriggers("W");
        }
    }

    // Reset all trigger parameters except the specified one
    void ResetOtherTriggers(string triggerToKeep)
    {
        animator.ResetTrigger("A");
        animator.ResetTrigger("D");
        animator.ResetTrigger("S");
        animator.ResetTrigger("W");

        animator.SetTrigger(triggerToKeep);
    }
}


