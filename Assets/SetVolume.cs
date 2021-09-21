using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour {

    public AudioMixer mixer;
    public AudioSource music;

    public void SetMusicLevel (float sliderValue)
    {
        mixer.SetFloat ("MusicVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", music.volume);
    }
}
