using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    

    
    void Update()
    {
        // pauses the game and check if the game is paused
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


    }

    // for the pausemenu to resume the game
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //pauses the game
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale =0f;
        GameIsPaused = true;

    }
    
    //to resume the game
    public void Back()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        
        GameIsPaused = true;
    }

    // quit to startscreen
    public void Quit()
    {
        SceneManager.LoadScene("Startscreen");
        Time.timeScale = 1f;
    }

}
