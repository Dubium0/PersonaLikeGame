using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] float speed;

    private Animator animator;

    private Rigidbody2D rb;

    private Vector2 movement;
    private int lastDireciton = 0;

    private float i = 1;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update() {
        FindDirection();

    }
    private void FixedUpdate() {
        Movement();
    }


    void FindDirection()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");
        // normalize the vector---------------------
        i =  movement.magnitude;
        if (i ==0)
        {
            i = 1;
        }
        movement.x = movement.x / i ;
        movement.y = movement.y / i;
        // -----------------------------------------
        HandleAnimation();

    }


    void HandleAnimation()
    {
        

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical",movement.y);
        animator.SetFloat("Speed", movement.magnitude);

        

        if (movement.x >0)
        {
            lastDireciton =2;
        }else if(movement.x <0)
        {
            lastDireciton =3;
        }
        else if(movement.y <0)
        {
            lastDireciton =1;
        }
        else if(movement.y >0)
        {
            lastDireciton =0;
        }

        animator.SetInteger("Direction",lastDireciton); 
        

    }

    void Movement()
    {
            rb.MovePosition(rb.position+movement*speed*Time.fixedDeltaTime);
    }
    
}
