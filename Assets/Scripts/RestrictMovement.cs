using UnityEngine;

public class RestrictMovement : MonoBehaviour
{
    public enum RestrictionDirection { Up, Down, Left, Right, UpLeft, UpRight, DownLeft, DownRight };
    public RestrictionDirection restrictionDirection;

    private PlayerMovement playerMovement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovement = other.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                ApplyRestriction();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerMovement != null)
            {
                RemoveRestriction();
                playerMovement = null;
            }
        }
    }

    private void ApplyRestriction()
    {
        switch (restrictionDirection)
        {
            case RestrictionDirection.Up:
                playerMovement.RestrictUp();
                break;
            case RestrictionDirection.Down:
                playerMovement.RestrictDown();
                break;
            case RestrictionDirection.Left:
                playerMovement.RestrictLeft();
                break;
            case RestrictionDirection.Right:
                playerMovement.RestrictRight();
                break;
            case RestrictionDirection.UpLeft:
                playerMovement.RestrictUpLeft();
                break;
            case RestrictionDirection.UpRight:
                playerMovement.RestrictUpRight();
                break;
            case RestrictionDirection.DownLeft:
                playerMovement.RestrictDownLeft();
                break;
            case RestrictionDirection.DownRight:
                playerMovement.RestrictDownRight();
                break;
        }
    }

    private void RemoveRestriction()
    {
        switch (restrictionDirection)
        {
            case RestrictionDirection.Up:
                playerMovement.ReleaseUp();
                break;
            case RestrictionDirection.Down:
                playerMovement.ReleaseDown();
                break;
            case RestrictionDirection.Left:
                playerMovement.ReleaseLeft();
                break;
            case RestrictionDirection.Right:
                playerMovement.ReleaseRight();
                break;
            case RestrictionDirection.UpLeft:
                playerMovement.ReleaseUpLeft();
                break;
            case RestrictionDirection.UpRight:
                playerMovement.ReleaseUpRight();
                break;
            case RestrictionDirection.DownLeft:
                playerMovement.ReleaseDownLeft();
                break;
            case RestrictionDirection.DownRight:
                playerMovement.ReleaseDownRight();
                break;
        }
    }
}
