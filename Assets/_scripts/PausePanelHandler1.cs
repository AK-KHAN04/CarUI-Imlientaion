using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PausePanelHandler1 : MonoBehaviour
{
    public GameObject PausePanel, GamePlayPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void HomeClick()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResumeClick()
    {
         PausePanel.SetActive(false);
         GamePlayPanel.SetActive(true);
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
}
