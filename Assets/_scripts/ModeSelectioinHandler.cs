using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelectioinHandler : MonoBehaviour
{

    public GameObject CarSelection, Select, MainMenu, ModeSelection;
    // Start is called before the first frame update
   
    public void Back()
    {
        ModeSelection.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void CarSelectionClick()
    {
        ModeSelection.SetActive(false);
        CarSelection.SetActive(true);
    }

    public void Mode(string mode)
    {
        PlayerPrefs.SetString("mode", mode);
        Debug.Log(PlayerPrefs.GetString("mode", mode));
    }

    public void SelectClick()
    {
        CarSelection.SetActive(false);
        MainMenHandler.instance.LevelSelection.SetActive(true);
    }

    public void CityClick()
    {
        CarSelection.SetActive(false);
        PlayerPrefs.SetString("mode", "city");
        MainMenHandler.instance.LevelSelection.SetActive(true);
    }

    public void ParkingClick()
    {
        CarSelection.SetActive(false);
        PlayerPrefs.SetString("mode", "parking");
        MainMenHandler.instance.LevelSelection.SetActive(true);
    }
}
