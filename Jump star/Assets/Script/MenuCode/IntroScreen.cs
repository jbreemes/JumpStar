using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScreen : MonoBehaviour
{
    
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Begin()
    {
        SceneManager.LoadScene("World");
    }

    public void Quit()
    {
        Debug.Log("Quitting...");
    }

}
