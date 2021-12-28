using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D PlayerRigidbody;
    private Vector2 shift;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        PlayerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        shift = Vector2.zero;
        shift.x = Input.GetAxisRaw("Horizontal");
        shift.y = Input.GetAxisRaw("Vertical");
        Debug.Log(shift);

        AnimationAndMovementUpdate();
    }

    private void FixedUpdate()
    {
        PlayerRigidbody.velocity = new Vector2(shift.x * speed, shift.y * speed);
    }

    void AnimationAndMovementUpdate() {
        if (shift != Vector2.zero)
        {
            FixedUpdate();
            animator.SetFloat("moveX", shift.x);
            animator.SetFloat("moveY", shift.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
}