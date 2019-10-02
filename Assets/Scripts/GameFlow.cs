using Interactive360.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : Singleton<GameFlow>
{
    public AudioManager aM;

    // need public GameObjects to make objects active / inactive ?
   
   
    public GameObject StefaniComputer;
    public GameObject RemiComputer;
    public GameObject MalcolmComputer;
    public GameObject server;
    public bool hasPlayedIntro;
    
   

    

    public void Start()
    {
       
   if (!hasPlayedIntro)
        {
            PlayIntroductionAudio();
           
        }
  

  
    }

    void Update()
    {
        //check to see what gameobject the gaze is on
        if (!aM.audioplayer.isPlaying)
        {
            if (StefaniComputer.GetComponent<VRInteractiveItem>().IsOver)
            {
                aM.StefanieComputerClip();
            }
            else if (RemiComputer.GetComponent<VRInteractiveItem>().IsOver)
            {
                aM.RemiComputerClip();
            }
            else if (server.GetComponent<VRInteractiveItem>().IsOver)
            {
                aM.serverClip();
            }else if (MalcolmComputer.GetComponent<VRInteractiveItem>().IsOver)
            {
                aM.MalcomComputerClip();
            }
         

        }
    }


    private void PlayIntroductionAudio()
    {

        aM.IntroductionClip();
        hasPlayedIntro = true;
    }

    internal void HandleObjectDrop(GameObject gameObject)
    {
   
    }


    internal void HandleObjectPickedUp(GameObject gameObject)
    {

   

    }
}


