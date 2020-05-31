using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;
    public AudioClip startClip;
    public AudioClip gameClip;
    public AudioClip krajClip;
    private AudioSource music;

    void Start()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            print("Duplicate music player self-destructing");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            music = GetComponent<AudioSource>();
            music.clip = startClip;
            music.loop = true;
            music.Play();
        }
    }

  
}
