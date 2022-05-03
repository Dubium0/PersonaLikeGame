using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;

    private Animator animator;

    private Rigidbody2D rb;

    private Vector2 movement;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update() {
         movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed", movement.magnitude);
        
        
        
    }
    private void FixedUpdate() {

        rb.MovePosition(rb.position+movement*speed*Time.fixedDeltaTime);


        
    }
    





}
