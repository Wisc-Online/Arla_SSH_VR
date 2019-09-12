using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioplayer;
    public AudioClip intro;
    public AudioClip ftpDataStream;
    public AudioClip sshDataStream;

    public AudioClip sshComputer;
    public AudioClip ftpComputer;

    public AudioClip linux;

    public AudioClip server;
    public AudioClip operatingSystemsIcons;
    

  

    public void IntroductionClip()
    {
        audioplayer.clip = intro;
        audioplayer.Play();
    }
    public void ftpDataStreamClip()
    {
        audioplayer.clip = ftpDataStream;
        audioplayer.Play();
    }

    public void sshDataStreamClip()
    {
        audioplayer.clip = sshDataStream;
        audioplayer.Play();
    }
    public void sshComputerClip()
    {
        audioplayer.clip = sshComputer;
        audioplayer.Play();
    }
    public void ftpComputerClip()
    {
        audioplayer.clip = ftpComputer;
        audioplayer.Play();
    }
    public void linuxClip()
    {
        audioplayer.clip = linux;
        audioplayer.Play();
    }
    public void serverClip()
    {
        audioplayer.clip = server;
        audioplayer.Play();
    }
    public void operatingSystemsIconsClip()
    {
        audioplayer.clip = operatingSystemsIcons;
        audioplayer.Play();
    }

    public void StopAllAudio()
    {
        audioplayer.Stop();
    }

   
}
