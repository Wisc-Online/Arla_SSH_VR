using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Kris this script will set the IsActive state of each of the seperate animations you create
public class PacketAnimationController : MonoBehaviour
{
    //Kris I see 8 seperate Animations If you think it needs more Add some and Link them.
    //I currently have them linked to all the packet animations for testing the code below.
    //Once you create the seperate gameobjects with the animations we just have to link them in the 
    //inspector

    //All the seperate gameobjects with animations for each section
    public GameObject animation_1_EveryThingFlows;
    public GameObject animation_2_EverythingIsBlockedAtFirewall;
    public GameObject animation_3_TrafficAllowedToInternet;
    public GameObject animation_4_TrafficAllowedBackFromInternet;
    public GameObject animation_5_FacebookFloods;
    public GameObject animation_6_FacebookBlocked;
    public GameObject animation_7_TopSecretFilesBlockedToServer;// make it look different from rest of packets?
    public GameObject animation_8_TopSecretFilesAllowed;

    //set of functions to hide and show the animations
    public void HideAllAnimations()
    {
        animation_1_EveryThingFlows.SetActive(false);
        animation_2_EverythingIsBlockedAtFirewall.SetActive(false);
        animation_3_TrafficAllowedToInternet.SetActive(false);
        animation_4_TrafficAllowedBackFromInternet.SetActive(false);
        animation_5_FacebookFloods.SetActive(false);
        animation_6_FacebookBlocked.SetActive(false);
        animation_7_TopSecretFilesBlockedToServer.SetActive(false);
        animation_8_TopSecretFilesAllowed.SetActive(false);
    }
    public void ShowHideAnimation1(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_1_EveryThingFlows.SetActive(true);
        }
        else
        {
            animation_1_EveryThingFlows.SetActive(false);
        }
    }
    public void ShowHideAnimation2(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_2_EverythingIsBlockedAtFirewall.SetActive(true);
        }
        else
        {
            animation_2_EverythingIsBlockedAtFirewall.SetActive(false);
        }
    }
    public void ShowHideAnimation3(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_3_TrafficAllowedToInternet.SetActive(true);
        }
        else
        {
            animation_3_TrafficAllowedToInternet.SetActive(false);
        }
    }
    public void ShowHideAnimation4(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_4_TrafficAllowedBackFromInternet.SetActive(true);
        }
        else
        {
            animation_4_TrafficAllowedBackFromInternet.SetActive(false);
        }
    }
    public void ShowHideAnimation5(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_5_FacebookFloods.SetActive(true);
        }
        else
        {
            animation_5_FacebookFloods.SetActive(false);
        }
    }
    public void ShowHideAnimation6(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_6_FacebookBlocked.SetActive(true);
        }
        else
        {
            animation_6_FacebookBlocked.SetActive(false);
        }
    }
    public void ShowHideAnimation7(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_7_TopSecretFilesBlockedToServer.SetActive(true);
        }
        else
        {
            animation_7_TopSecretFilesBlockedToServer.SetActive(false);
        }
    }
    public void ShowHideAnimation8(bool state)
    {
        HideAllAnimations();
        if (state == true)
        {
            animation_8_TopSecretFilesAllowed.SetActive(true);
        }
        else
        {
            animation_8_TopSecretFilesAllowed.SetActive(false);
        }
    }
}
