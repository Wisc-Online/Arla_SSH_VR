
using Interactive360.Utils;
using UnityEngine;

public class PlayDataStreamAudio : MonoBehaviour
{
    public AudioSource audioplayer;
    public AudioClip clip;
    public GameObject laptop;
    // Start is called before the first frame update
    void Start()
    {
        audioplayer.clip = clip;
        audioplayer.Play();

      
    }
    private void Update()
    {
        if (!audioplayer.isPlaying)
        {
            if (laptop.GetComponent<VRInteractiveItem>().IsOver)
            {
                audioplayer.Play();
            }
        }

    }
}
