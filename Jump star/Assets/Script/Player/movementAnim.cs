using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementAnim : MonoBehaviour
{
    private Animator anim;
    private float speed = 5f;

   
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

   
    void Update()
    {
        
         float horizontalMove = Input.GetAxisRaw("Horizontal")* speed;
        
        

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
         

        
        
    }
}
