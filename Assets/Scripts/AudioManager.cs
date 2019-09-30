using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public AudioSource audioplayer;
    public AudioClip intro;

    public AudioClip StefanieComputer;
  

    public AudioClip RemiComputer;
  

    public AudioClip MalcolmComputer;
   

    public AudioClip server;
   
    

  

    public void IntroductionClip()
    {
        audioplayer.clip = intro;
        audioplayer.Play();
    }
    
    public void RemiComputerClip()
    {
        audioplayer.clip = RemiComputer;
        audioplayer.Play();
    }
    public void StefanieComputerClip()
    {
        audioplayer.clip = StefanieComputer;
        audioplayer.Play();
    }
    public void MalcomComputerClip()
    {
        audioplayer.clip = MalcolmComputer;
        audioplayer.Play();
    }

    
    public void serverClip()
    {
        audioplayer.clip = server;
        audioplayer.Play();
    }

    public void StopAllAudio()
    {
        audioplayer.Stop();
    }

   
}
