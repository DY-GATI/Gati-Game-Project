using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        // Check for movement input
        bool isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ||
                        Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow);

        // If there is movement input, set the animator's "isWalking" parameter to true
        if (isMoving)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}