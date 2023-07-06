using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayHandler : MonoBehaviour
{
    public static GamePlayHandler instance;


    public GameObject SettingPanel,GamePlayPanel,PausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PauseButtonClick()
    {
        GamePlayPanel.SetActive(false);
        PausePanel.SetActive(true);
    }

    public void SettingButtonClick()
    {
        GamePlayPanel.SetActive(false);
        SettingPanel.SetActive(true);
    }

    public void Gears(Slider G)
    {
        PlayerPrefs.SetFloat("Gears", G.value);
        Debug.Log(PlayerPrefs.GetFloat("Gears"));
    }
}
