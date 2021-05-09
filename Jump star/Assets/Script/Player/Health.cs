using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite FullHP;
    public Sprite EmptyHP;

    public static float Radius;
    public Transform feet;

    private bool Damage;
    public LayerMask spikes;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        
    }


    private void Update()
    {   

        Radius = movementSpeed.checkRadius;

        



        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health){
                hearts[i].sprite = FullHP;
            }
            else
            {
                hearts[i].sprite = EmptyHP;
            }

            if (i < numOfHearts){
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

            

        } 

       

                
    }

    private void FixedUpdate()
    {
        StartCoroutine(Damagecounter());
    }

    IEnumerator Damagecounter()
    {
          yield return new WaitForSeconds(6);
            
            

          Damage = Physics2D.OverlapCircle(feet.position, Radius, spikes);
          if (Damage == true)
          {
            health--;
          }

    }

   



}


