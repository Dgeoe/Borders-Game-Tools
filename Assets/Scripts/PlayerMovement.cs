using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool canMoveUp = true;
    private bool canMoveDown = true;
    private bool canMoveLeft = true;
    private bool canMoveRight = true;
    private bool canMoveUpLeft = true;
    private bool canMoveUpRight = true;
    private bool canMoveDownLeft = true;
    private bool canMoveDownRight = true;

    public float moveSpeed = 1f;
    public bool inverse = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && canMoveRight && !inverse)
        {
            Move(Vector3.right);
        }
         else if (Input.GetKeyDown(KeyCode.RightArrow) && canMoveLeft && inverse)
        {
            Move(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && canMoveLeft && !inverse)
        {
            Move(Vector3.left);
        }
         else if (Input.GetKeyDown(KeyCode.LeftArrow) && canMoveRight && inverse)
        {
            Move(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && canMoveUp)
        {
            Move(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && canMoveDown)
        {
            Move(Vector3.back);
        }
    }

    void Move(Vector3 direction)
    {
        transform.Translate(direction * moveSpeed);
    }

    public void RestrictUp()
    {
        canMoveUp = false;
    }

    public void RestrictDown()
    {
        canMoveDown = false;
    }

    public void RestrictLeft()
    {
        canMoveLeft = false;
    }

    public void RestrictRight()
    {
        canMoveRight = false;
    }

    public void RestrictUpLeft()
    {
        canMoveUp = false;
        canMoveLeft = false;
    }

    public void RestrictUpRight()
    {
        canMoveUp = false;
        canMoveRight = false;
    }

    public void RestrictDownLeft()
    {
        canMoveDown = false;
        canMoveLeft = false;
    }

    public void RestrictDownRight()
    {
        canMoveDown = false;
        canMoveRight = false;
    }

    public void ReleaseUp()
    {
        canMoveUp = true;
    }

    public void ReleaseDown()
    {
        canMoveDown = true;
    }

    public void ReleaseLeft()
    {
        canMoveLeft = true;
    }

    public void ReleaseRight()
    {
        canMoveRight = true;
    }

    public void ReleaseUpLeft()
    {
        canMoveUp = true;
        canMoveLeft = true;
    }

    public void ReleaseUpRight()
    {
        canMoveUp = true;
        canMoveRight = true;
    }

    public void ReleaseDownLeft()
    {
        canMoveDown = true;
        canMoveLeft = true;
    }

    public void ReleaseDownRight()
    {
        canMoveDown = true;
        canMoveRight = true;
    }
}
