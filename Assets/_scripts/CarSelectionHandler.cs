using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarSelectionHandler : MonoBehaviour
{
    public GameObject Carselection, MainMenu, CashStore;
    public GameObject[] cars;
    public Button next, prev;
    public int max_cars;
    public int curr=0;

    private void Start()
    {
        cars[curr].SetActive(true);
        max_cars = cars.Length-1;
        PlayerPrefs.SetInt("SelectedCar", curr);


        if (curr >= max_cars)
        {
            next.interactable = false;
        }
        else if(curr <= 0)
        {
            prev.interactable = false;
        }
        
    }

    public void Back()
    {
        Carselection.SetActive(false);
        MainMenHandler.instance.LevelSelection.SetActive(true);
    }

    public void CashClick()
    {
        Carselection.SetActive(false);
        CashStore.SetActive(true);
    }

    public void StoreClick()
    {
        Carselection.SetActive(false);
        CashStore.SetActive(true);
    }

    public void SelectClick()
    {
        Carselection.SetActive(false);
        Debug.Log("Level " + PlayerPrefs.GetInt("level"));
        Debug.Log("Mode is " + PlayerPrefs.GetString("mode"));

        SceneManager.LoadScene(2);
    }

    public void Next()
    {
        cars[curr].SetActive(false);
        curr++;
        cars[curr].SetActive(true);

        if( curr >= max_cars)
        {
            next.interactable = false;
        }
        else if(curr >= 0)
        {
            prev.interactable = true;
        }
        PlayerPrefs.SetInt("SelectedCar", curr);
        Debug.Log(PlayerPrefs.GetInt("SelectedCar"));
    }

    public void Previous()
    {
        cars[curr].SetActive(false);
        curr--;
        cars[curr].SetActive(true);

        if (curr == 0)
        {
            prev.interactable = false;
        }
        else if(curr <= max_cars)
        {
            next.interactable = true;
        }
        PlayerPrefs.SetInt("SelectedCar", curr);
        Debug.Log(PlayerPrefs.GetInt("SelectedCar"));

    }

}
