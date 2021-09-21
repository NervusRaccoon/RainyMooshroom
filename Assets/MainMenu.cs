using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene(5);
    }

    public void PlayLevel4()
    {
        SceneManager.LoadScene(7);
    }

    public void PlayLevel5()
    {
        SceneManager.LoadScene(9);
    }

    public void QuitGame ()
    {
        Debug.Log("App quitted!");
        Application.Quit();
    }

    public AudioSource music;

    void Start()
    {
        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            music.volume = PlayerPrefs.GetFloat("MusicVolume");
        }
    }
}
