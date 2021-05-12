using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScreen : MonoBehaviour
{
    public GameObject Startsceen;
    public GameObject Soundscreen;


    // to go to the sound option menu
    public void Options()
    {
        Startsceen.SetActive(false);
        Soundscreen.SetActive(true);
    }

    // for the backbutton in the options menu
    public void Back()
    {
        Startsceen.SetActive(true);
        Soundscreen.SetActive(false);
    }

    // to load the game world
    public void Begin()
    {
        SceneManager.LoadScene("World");
        Time.timeScale = 1f;
    }


    // for quitting the game not working right know
    public void Quit()
    {
        Debug.Log("Quitting...");
    }

}
