using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEncryptedAudio : MonoBehaviour
{
    public AudioSource audioplayer;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        audioplayer.clip = clip;
        audioplayer.Play();
    }

  
}
