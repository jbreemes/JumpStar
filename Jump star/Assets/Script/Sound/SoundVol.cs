using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

public class SoundVol : MonoBehaviour
{
    

    
    public AudioSource Audio;
    private float musicVolume = 0.2f;
    
    // for volume mixer
    public void start()
    {
        Audio.Play();
        gameObject.GetComponent<StartScreen>();
        

    }

    void Update()
    {
        Audio.volume = musicVolume;

    }

    public void VolumeMixer(float vol)
    {

        musicVolume = vol;

    }



   
     


}
