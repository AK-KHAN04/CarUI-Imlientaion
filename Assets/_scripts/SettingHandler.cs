using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingHandler : MonoBehaviour
{
    public GameObject GamePlay, soundMenu;
    public Slider MusicSlider;
    public Button On, Off;
    public AudioSource Audio;


    private void Start()
    {
        On.interactable = false;
        Audio.enabled = true;
        Audio.Play();
        Audio.volume = PlayerPrefs.GetFloat("MusicSpeed");
        MusicSlider.value = PlayerPrefs.GetFloat("MusicSpeed");
    }


    public void MusicOn()
    {
        PlayerPrefs.SetInt("Music", 1);
        Debug.Log(PlayerPrefs.GetInt("Music"));
        Audio.Play();
        Off.interactable = true;
        On.interactable = false;
    }

    public void MusicOff()
    {
        PlayerPrefs.SetInt("Music", 0);
        Debug.Log(PlayerPrefs.GetInt("Music"));
        Off.interactable = false;
        On.interactable = true;
        // Audio.enabled = false;
        Audio.Pause();

    }

    public void MusicSpeed(Slider M)
    {
        PlayerPrefs.SetFloat("MusicSpeed", M.value);
        Debug.Log(PlayerPrefs.GetFloat("MusicSpeed"));
        Audio.volume = PlayerPrefs.GetFloat("MusicSpeed");

    }

    public void Steering()
    {
        PlayerPrefs.SetInt("Control", 1);
        Debug.Log(PlayerPrefs.GetInt("Control"));

    }

    public void Tilt()
    {
        PlayerPrefs.SetInt("Control", 0);
        Debug.Log(PlayerPrefs.GetInt("Control"));

    }

    public void ButtonsClick()
    {
        PlayerPrefs.SetInt("Control", 2);
        Debug.Log(PlayerPrefs.GetInt("Control"));

    }

    public void Resume()
    {
        GamePlay.SetActive(true);
        soundMenu.SetActive(false);
    }

}
