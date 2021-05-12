using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public float health;
    public int numOfHearts;
    public float dps = 2f;

    public Image[] hearts;
    public Sprite FullHP;
    public Sprite EmptyHP;

    public static float Radius;
    public Transform feet;

    private bool Damage;
    public LayerMask spikes;
    public GameObject restart;

   
    private void Update()
    {

        Radius = movementSpeed.checkRadius;

        //loop for the hearts
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = FullHP;
            }
            else
            {
                hearts[i].sprite = EmptyHP;
            }

            //enables the full hp or empty hp images 
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

            Damage = Physics2D.OverlapCircle(feet.position, Radius, spikes);
            if (Damage == true)
            {
                health -= Time.deltaTime * dps;
            }
            
            
            

        }
        // checks if the player dies to start the restart screen
           if(health < 0)
           {
            Restart();
           }
                




    }

    void Restart()
    {
      restart.SetActive(true);
      Time.timeScale = 0f;            
    }

   public void restartButton()
   {   
       Time.timeScale = 1f;
       SceneManager.LoadScene("Startscreen");
        
   }

  





}


