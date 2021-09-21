using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveOrLoadPrefs : MonoBehaviour {

    //public float Volume;
    //void Awake()
    //{
    //    VolumeSlider = GameObject.Find("Slider");
    //}

    //public void SavePrefs(float newValue)
    //{
    //  Debug.Log(VolumeSlider.GetComponent<Slider>().value);

    //PlayerPrefs.SetFloat("Volume", VolumeSlider.value);
    //}

    public GameObject VolumeSlider;

    public void SavePrefs(float newValue)
    {
        Debug.Log(VolumeSlider.GetComponent<Slider>().value);

        //PlayerPrefs.SetFloat("Volume", VolumeSlider.value); 
    }

    // Use this for initialization 
    void Start()
    {

    }
}
