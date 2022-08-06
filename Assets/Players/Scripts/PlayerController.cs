using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 4f;

    private Vector2 moveInput;

    private bool facingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        if(moveInput != Vector2.zero) {
            animator.SetBool("isWalking", true);
        } else if(moveInput == Vector2.zero){
            animator.SetBool("isWalking", false);
        }

        if(facingRight == false && moveInput.x > 0) {
            Flip();
        } else if(facingRight == true && moveInput.x < 0) {
            Flip();
        }
    }

    void Flip() {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void OnMove(InputAction.CallbackContext context) {
        moveInput = context.ReadValue<Vector2>();
    }

}
