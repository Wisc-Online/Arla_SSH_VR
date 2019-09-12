using System.Collections;
using UnityEngine;
using Interactive360.Utils;
using UnityEngine.UI;

public class AnswerButtonGaze : MonoBehaviour
{
    private Button m_Button;                        // The button we are going to call onClick for
    private bool isOver = false;                    // Bool value to let us know whether or not the gaze is over the button
    private VRInteractiveItem m_InteractiveItem;    // The interactable object for where the user should look to cause on "onClick" event.
    public float m_WaitTime = 2f;                   // The time we are waiting to complete the gaze interaction 
    public ParticleSystem myParticles;

    private void Awake()
    {
        m_Button = GetComponent<Button>(); //Reference to Button component 
        m_InteractiveItem = GetComponent<VRInteractiveItem>(); //Reference to VRInteractiveItem Component 
    }

    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;

    }

    // When the user looks at the rendering of the scene, wait 1 second
    // if we are still over after 1 full second, invoke click
    private IEnumerator WaitAndClick()
    {
        yield return new WaitForSeconds(m_WaitTime);
        if (isOver == true)
        {
            m_Button.onClick.Invoke();
        }

    }

    private void HandleOver()
    {
        isOver = true;
        //myParticles.Play();

        StartCoroutine(WaitAndClick());
    }

    private void HandleOut()
    {
        isOver = false;

       // myParticles.Stop();
    }


}
