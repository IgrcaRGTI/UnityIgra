using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsButton : MonoBehaviour {

    public int PercetForVolume;
    public Slider MainSlider;


    // Use this for initialization
    void Start() {
        PercetForVolume = (int)GameObject.Find("MainSlider").GetComponent<Slider>().value;
    }

    // Update is called once per frame
    void Update() {

    }
    public void ValueChangeCheck()
    {
        Debug.Log((GameObject.Find("MainSlider").GetComponent<Slider>().value).ToString());
    }
}
