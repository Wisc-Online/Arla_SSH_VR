using Interactive360.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : Singleton<GameFlow>
{
    public AudioManager aM;

    // need public GameObjects to make objects active / inactive ?
   
    public GameObject linux;
    public GameObject ftpComputer;
    public GameObject sshComputer;
    public GameObject server;
    
   

    

    public void Start()
    {
       
   
   PlayIntroductionAudio();

  
    }

    void Update()
    {
        //check to see what gameobject the gaze is on
        if (!aM.audioplayer.isPlaying)
        {
            if (linux.GetComponent<VRInteractiveItem>().IsOver)
            {
                //check to see if running before running again
                aM.linuxClip();

            }
            else if (ftpComputer.GetComponent<VRInteractiveItem>().IsOver)
            {
                aM.ftpComputerClip();
            }
            else if (sshComputer.GetComponent<VRInteractiveItem>().IsOver)
            {
                aM.sshComputerClip();
            }
            else if (server.GetComponent<VRInteractiveItem>().IsOver)
            {
                aM.serverClip();
            }

        }
    }


    private void PlayIntroductionAudio()
    {

        aM.IntroductionClip();
     
    }

    internal void HandleObjectDrop(GameObject gameObject)
    {
   
    }


    internal void HandleObjectPickedUp(GameObject gameObject)
    {

   

    }
}


