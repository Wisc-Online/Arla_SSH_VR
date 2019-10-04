using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCommander : MonoBehaviour
{
    public GameObject googleScreen1;
    public GameObject googleScreen2;
    public GameObject googleScreen3;
    public GameObject googleScreen4;
    //THis isnt right rethink
    public void ShowHideGoogleScreen1(bool changeStateToThis, int screenNumber)
    {
        switch (screenNumber)
        {
            case 1:
                if (changeStateToThis == false)
                {
                    googleScreen1.SetActive(false);
                }
                else
                {
                    googleScreen1.SetActive(true);
                }
                break;
            case 2:
                if (changeStateToThis == false)
                {
                    googleScreen2.SetActive(false);
                }
                else
                {
                    googleScreen2.SetActive(true);
                }
                break;
            case 3:
                if (changeStateToThis == false)
                {
                    googleScreen3.SetActive(false);
                }
                else
                {
                    googleScreen3.SetActive(true);
                }
                break;
            case 4:
                if (changeStateToThis == false)
                {
                    googleScreen4.SetActive(false);
                }
                else
                {
                    googleScreen4.SetActive(true);
                }
                break;
            case 5:
                googleScreen1.SetActive(false);
                googleScreen2.SetActive(false);
                googleScreen3.SetActive(false);
                googleScreen4.SetActive(false);

                break;
        }


    }
}
