using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementAnim : MonoBehaviour
{
    private Animator anim;
    private float speed = 5f;
    private bool isGrounded;
    public Transform feetPos;
    public static float Radius;
    public LayerMask Ground;



    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

   
    void Update()
    {
         Radius = movementSpeed.checkRadius;
         float horizontalMove = Input.GetAxisRaw("Horizontal")* speed;
        isGrounded = Physics2D.OverlapCircle(feetPos.position, Radius, Ground);


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetTrigger("isJumping");

        }

        if (isGrounded == true)
        {
            anim.SetBool("isGrounded", true);
        }
        else
        {
            anim.SetBool("isGrounded", false);
        }

        
        
    }
}
