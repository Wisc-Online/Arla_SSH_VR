
using Interactive360.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HotSpotsManager : MonoBehaviour
{
    public string scene;
    public GameObject fadeOut;
    private VRInteractiveItem m_InteractiveItem;
    private Animator anim;
    private Image fadeImage;
    private bool isLoaded = false;

    // Start is called before the first frame update
    private void Awake()
    {
        m_InteractiveItem = GetComponent<VRInteractiveItem>();
    }
    // Update is called once per frame
    void Update()
    {
        //if (m_InteractiveItem.IsOver && !isLoaded)
        //{
        //    isLoaded = true;
        //    StartCoroutine(FadeOutAndIn(scene));
        //}
    }
   
    public IEnumerator FadeOutAndIn()
    {
        //get references to animatior and image component 
        anim = fadeOut.GetComponent<Animator>();
        fadeImage = fadeOut.GetComponent<Image>();

       

        //set FadeOut to true on the animator so our image will fade out
        anim.SetBool("FadeOut", true);

        //wait until the fade image is entirely black (alpha=1) then load next scene
        yield return new WaitUntil(() => fadeImage.color.a == 1);
         SceneManager.LoadScene(scene);
        Scene sceneloaded = SceneManager.GetSceneByName(scene);
     //  Debug.Log("loading scene:" + scene.name);
        yield return new WaitUntil(() => sceneloaded.isLoaded);

      
        //set FadeOUt to false on the animator so our image will fade back in 
        anim.SetBool("FadeOut", false);

        //wait until the fade image is completely transparent (alpha = 0) and then turn loading UI off and control UI back on
       


    }
}
