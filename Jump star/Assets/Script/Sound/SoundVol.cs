using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVol : MonoBehaviour
{
    public AudioSource Audio;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        Audio = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (Audio.isPlaying) return;
    }

    public void StopMusic()
    {
        Audio.Stop();
    }


}
