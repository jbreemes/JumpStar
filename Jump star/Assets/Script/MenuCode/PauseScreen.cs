using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();

                
            }
            else
            {
                Pause();
                
            }
            
        }


        if (Input.GetKey(KeyCode.A) && GameIsPaused == false)
        {
            transform.localScale = new Vector2(-0.3146253f, 0.286523f);
        }
        else if (Input.GetKey(KeyCode.D)&& GameIsPaused == false)
        {
            transform.localScale = new Vector2(0.3146253f, 0.286523f);
        }

    }

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale =0f;
        GameIsPaused = true;

    }
    
    public void Back()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        
        GameIsPaused = true;
    }

    public void Quit()
    {
        SceneManager.LoadScene("Startscreen");
        Time.timeScale = 1f;
    }

}
