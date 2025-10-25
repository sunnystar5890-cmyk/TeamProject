using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputControls : MonoBehaviour
{
    Rigidbody2D rb2D;
    Animator animator;

    [SerializeField] private float moveSpeed = 2f;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 movedir = context.ReadValue<Vector2>();

        GetComponent<Rigidbody2D>().linearVelocity = moveSpeed * movedir;

        animator.SetFloat("InputX", movedir.x);
        animator.SetFloat("InputY", movedir.y);
    }
}
