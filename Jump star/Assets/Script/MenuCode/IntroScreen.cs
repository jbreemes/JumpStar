using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScreen : MonoBehaviour
{
    public GameObject Startsceen;
    public GameObject Soundscreen;


    public void Options()
    {
        Startsceen.SetActive(false);
        Soundscreen.SetActive(true);
    }

    public void Back()
    {
        Startsceen.SetActive(true);
        Soundscreen.SetActive(false);
    }

    public void Begin()
    {
        SceneManager.LoadScene("World");
        Time.timeScale = 1f;
    }



    public void Quit()
    {
        Debug.Log("Quitting...");
    }

}
