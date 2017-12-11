using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class OptionsButton : MonoBehaviour {

    public AudioMixer AudioMixer;

    Resolution[] resolutions;
     void Start()
    {
      resolutions=  Screen.resolutions;
        //TBC mogoče za rezolucije.
    }


    public void SetVolume(float Volume)
    {
        AudioMixer.SetFloat("Volume", Volume);
        Debug.Log(Volume);
    }
    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

}
