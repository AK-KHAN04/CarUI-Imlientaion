using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenHandler : MonoBehaviour
{
    public static MainMenHandler instance;

    public Text text;
    public float cash;
    

    public GameObject CarSelection, CashStore, ExitScreen, GamePaused, GamePlay,
        LevelComplete, LevelFail, LevelSelection, LoadingScreen, MainMenu, ModeSelection, NotEnoughCah, Pause, Setting, SoundControl;


    public void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine("good");
    }
    public void startClick()
    {
        MainMenu.SetActive(false);
        ModeSelection.SetActive(true);
    }

    public void settingClick()
    {
        MainMenu.SetActive(false);
        Setting.SetActive(true);
    }

    public void rateUsClick()
    {

    }

    public void privacyClick()
    {

    }

    public void gamesClick()
    {
        MainMenu.SetActive(false);
        ModeSelection.SetActive(true);
    }

    public void garageClick()
    {
        MainMenu.SetActive(false);
        CarSelection.SetActive(true);
    }

    public void shareClick()
    {
        Application.OpenURL("http://unity3d.com/");
    }

    public void removeAdsClick()
    {
        MainMenu.SetActive(false);
        NotEnoughCah.SetActive(true);
    }

    public void CashClick()
    {
        MainMenu.SetActive(false);
        CashStore.SetActive(true);
    }


    public void exitClick()
    {
        MainMenu.SetActive(false);
        ExitScreen.SetActive(true);
    }

    IEnumerator good()
    {
        Debug.Log("Coroutine");
        yield return new WaitForSeconds(2f);
       // PlayerPrefs.SetFloat("cash", 10000);

        text.text = PlayerPrefs.GetFloat("cash").ToString();
    }

}
