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
        max_cars = cars.Length;
    }

    public void back()
    {
        Carselection.SetActive(false);
        MainMenHandler.instance.LevelSelection.SetActive(true);
    }

    public void cashClick()
    {
        Carselection.SetActive(false);
        CashStore.SetActive(true);
    }

    public void storeClick()
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

        if( curr == 5)
        {
            next.interactable = false;
        }
    }

    public void Previous()
    {

    }
    
}
