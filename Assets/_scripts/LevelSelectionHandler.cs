using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionHandler : MonoBehaviour
{
    public GameObject LevelSelection;

    public void LevelButtonClick(int levelNo)
    {
        PlayerPrefs.SetInt("level", levelNo);
        Debug.Log(PlayerPrefs.GetInt("level"));
    }

    public void BackClick()
    {
        LevelSelection.SetActive(false);
        MainMenHandler.instance.MainMenu.SetActive(true);
    }

    public void SelectClick()
    {
        LevelSelection.SetActive(false);
        MainMenHandler.instance.CarSelection.SetActive(true);
    }
}
