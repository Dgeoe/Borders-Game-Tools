using UnityEngine;

public class syncedbutton : MonoBehaviour
{
    public bool playerInside = false;

    //private void OnTriggerEnter(Collider other)
   // {
        //if (other.CompareTag("Player"))
        //{
           // playerInside = true;
            //Debug.Log("Player entered the button collider.");
        //}
    //}

    //use below if we want both buttons need to be pressed at once (needs slight modifying)

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            Debug.Log("Player exited the button collider.");
        }
    }
}