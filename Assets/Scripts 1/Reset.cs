using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    // Assign this in the Inspector to the button you want to trigger the level reset
    public KeyCode resetKey = KeyCode.R;

    void Update()
    {
        // Check if the assigned key is pressed
        if (Input.GetKeyDown(resetKey))
        {
            // Call the Reset function
            ResetLvl();
        }
    }

    public void ResetScene()
    {
        // Call the Reset function when the UI button is clicked
        ResetLvl();
    }

    void ResetLvl()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}


