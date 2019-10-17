
using Interactive360.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HotSpotsManager : MonoBehaviour
{
    public static HotSpotsManager instance = null;
    public string sceneToLoad;
    int s;
    AsyncOperation asyncLoad;
    public bool useFade;
    public GameObject fadeOverlay;
    Scene scene;
    string activeScene;
    Animator anim;
    Image fadeImage;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
        activeScene = "Arla SSH";
    }
    void Awake()
    {
       
    }

    public IEnumerator FadeOutAndIn()
    {
        //get references to animatior and image component 
        anim = fadeOverlay.GetComponent<Animator>();
        fadeImage = fadeOverlay.GetComponent<Image>();




        //set FadeOut to true on the animator so our image will fade out
        anim.SetBool("FadeOut", true);

        //wait until the fade image is entirely black (alpha=1) then load next scene
        yield return new WaitUntil(() => fadeImage.color.a == 1);
        SelectScene();
        //SceneManager.LoadScene(sceneToLoad);
      //  Scene scene = SceneManager.GetSceneByName(sceneToLoad);
        //Debug.Log("loading scene:" + scene.name);
    //    yield return new WaitUntil(() => scene.isLoaded);

        // grab video and wait until it is loaded and prepared before starting the fade out


        //set FadeOUt to false on the animator so our image will fade back in 
        anim.SetBool("FadeOut", false);

        //wait until the fade image is completely transparent (alpha = 0) and then turn loading UI off and control UI back on
        yield return new WaitUntil(() => fadeImage.color.a == 0);

    }



    //public IEnumerator SelectScene()
    //{
    //    //if we want to use the fading between scenes, start the coroutine here
    //    if (sceneToLoad == "FTPDataStream")

    //      asyncLoad =  SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);

    //    else if (sceneToLoad == "MIMDataStream")
    //    {
    //        asyncLoad = SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
    //    }
    //    else if (sceneToLoad == "SSHDataStream")
    //    {
    //        asyncLoad = SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
    //    }else
    //    {
    //        asyncLoad = SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
    //    }

    //  while (!asyncLoad.isDone)
    //    {
    //        yield return null;
    //    }

    public void SelectScene()
    {
        int s = 0;
        //if we want to use the fading between scenes, start the coroutine here
        if (sceneToLoad == "FTPDataStream")
        {
           SceneManager.LoadScene(1, LoadSceneMode.Single);
            SceneManager.UnloadSceneAsync(0);
            s = 1;
        }
        else if (sceneToLoad == "MIMDataStream")
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
            SceneManager.UnloadSceneAsync(0);
            s = 2;
        }
        else if (sceneToLoad == "SSHDataStream")
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
            SceneManager.UnloadSceneAsync(0);
            s = 3;
        }
        else
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
            SceneManager.UnloadSceneAsync(s);
        }

       
    }


}
