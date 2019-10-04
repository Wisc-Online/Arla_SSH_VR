using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplayManager : MonoBehaviour
{

    public GameObject welcomeText;
    public GameObject howWouldYouReply;
    public GameObject howWouldYouReply2;
    public GameObject howWouldYouReply3;
    public GameObject howWouldYouReply4;

    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;

    private void Start()
    {
        howWouldYouReply.SetActive(false);
    }
    public void HideWelcomeText()
    {
        welcomeText.SetActive(false);
    }
    public void ShowHowWouldYouReply()
    {
        howWouldYouReply.SetActive(true);
    }
    public void HideHowWouldYouReply()
    {
        howWouldYouReply.SetActive(false);
    }

    public void ShowWelcomeText()
    {
        welcomeText.SetActive(true);
    }

    public void ShowHowWouldYouReply2()
    {
        howWouldYouReply2.SetActive(true);
    }
    public void HideHowWouldYouReply2()
    {
        howWouldYouReply2.SetActive(false);
    }
    public void ShowHowWouldYouReply3()
    {
        howWouldYouReply3.SetActive(true);
    }
    public void HideHowWouldYouReply3()
    {
        howWouldYouReply3.SetActive(false);
    }
    public void ShowHowWouldYouReply4()
    {
        howWouldYouReply4.SetActive(true);
    }
    public void HideHowWouldYouReply4()
    {
        howWouldYouReply4.SetActive(false);
    }
    //Questions

    public void ShowQuestion1()
    {
        question1.SetActive(true);
    }
    public void HideQuestion1()
    {
        question1.SetActive(false);
    }
    public void ShowQuestion2()
    {
        question2.SetActive(true);
    }
    public void HideQuestion2()
    {
        question2.SetActive(false);
    }

    public void ShowQuestion3()
    {
        question3.SetActive(true);
    }
    public void HideQuestion3()
    {
        question3.SetActive(false);
    }

    public void ShowQuestion4()
    {
        question4.SetActive(true);
    }
    public void HideQuestion4()
    {
        question4.SetActive(false);
    }
}
