using UnityEngine;

public class RestrictMovement : MonoBehaviour
{
    public enum RestrictionDirection { Up, Down, Left, Right, UpLeft, UpRight, DownLeft, DownRight, Null, RightLeft, UpDown, UpDownRight, UpDownLeft, UpLeftRight, DownLeftRight };
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
            case RestrictionDirection.Null:
                break;
            case RestrictionDirection.RightLeft:
                playerMovement.RestrictRightLeft();
                break;
            case RestrictionDirection.UpDown:
                playerMovement.RestrictUpDown();
                break;
            case RestrictionDirection.UpDownLeft:
                playerMovement.RestrictUpDownLeft();
                break;
            case RestrictionDirection.UpDownRight:
                playerMovement.RestrictUpDownRight();
                break;
            case RestrictionDirection.UpLeftRight:
                playerMovement.RestrictUpRightLeft();
                break;
            case RestrictionDirection.DownLeftRight:
                playerMovement.RestrictDownRightLeft();   
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
            case RestrictionDirection.RightLeft:
                playerMovement.ReleaseRightLeft();
                break;
            case RestrictionDirection.UpDown:
                playerMovement.ReleaseUpDown();
                break;
            case RestrictionDirection.UpDownLeft:
                playerMovement.ReleaseUpDownLeft();
                break;
            case RestrictionDirection.UpDownRight:
                playerMovement.ReleaseUpDownRight();
                break;
            case RestrictionDirection.UpLeftRight:
                playerMovement.ReleaseUpLeftRight();
                break;
            case RestrictionDirection.DownLeftRight:
                playerMovement.ReleaseDownLeftRight();
                break;
        }
    }
}