using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Soundscene : MonoBehaviour {


    private static Soundscene musicmanager;
   
    public void Awake()
    {


        DontDestroyOnLoad(this);

        if (musicmanager == null)
        {
            musicmanager = this;

        }
        else
        {
            Destroy(gameObject);
        }

    }
}
