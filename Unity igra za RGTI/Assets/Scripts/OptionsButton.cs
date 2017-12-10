using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class OptionsButton : MonoBehaviour {

    public AudioMixer AudioMixer;


    public void SetVolume(float Volume)
    {
        AudioMixer.SetFloat("Volume", Volume);
        Debug.Log(Volume);
    }

}
