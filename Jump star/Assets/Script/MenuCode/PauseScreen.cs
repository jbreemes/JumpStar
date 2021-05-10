using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject SoundOption;

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
    }

   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        SoundOption.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale =0f;
        GameIsPaused = true;

    }
    public void LoadMenu()
    {
        
        pauseMenuUI.SetActive(false);
        SoundOption.SetActive(true);
        GameIsPaused = true;

    }
    public void Back()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        SoundOption.SetActive(false);
        GameIsPaused = true;
    }

    public void Quit()
    {
        SceneManager.LoadScene("Startscreen");
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        SoundOption.SetActive(false);

    }


}
