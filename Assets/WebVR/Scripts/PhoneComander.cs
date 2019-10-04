using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneComander : MonoBehaviour
{
    public Vector3 phonePosition, originalPhonePosition;
    public GameObject phoneAnimation;
   
    public GameObject phoneHandle;
    public GameObject phoneBase;
    public Quaternion phoneRotation;
    private void Start()
    {
        originalPhonePosition = phoneHandle.transform.position;
        phoneRotation = phoneHandle.transform.rotation;
    }
    public void Update()
    {

    }


    public void StartPhoneAnimation()
    {
        //Kris Start animation
        phoneAnimation.SetActive(true);
    }

    public void EndPhoneAnimation()
    {
        //Kris End Animation
        phoneAnimation.SetActive(false);
    }

    public void ResetPosition()
    {
        phoneHandle.transform.position = originalPhonePosition;
        phoneHandle.transform.rotation = phoneRotation;
    }
}
