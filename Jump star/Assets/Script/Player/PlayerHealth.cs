using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public float health;
    public int numOfHearts;
    public float dps = 0.8f;

    public Image[] hearts;
    public Sprite FullHP;
    public Sprite EmptyHP;

    public static float Radius;
    public Transform feet;

    private bool Damage;
    public LayerMask spikes;
    public GameObject restart;


    private void Awake()
    {
        Application.targetFrameRate = 60;

    }


    private void Update()
    {

        Radius = movementSpeed.checkRadius;


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


