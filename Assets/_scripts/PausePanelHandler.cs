using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanelHandler : MonoBehaviour
{
    public GameObject MainMenu, PausePanel;

    public void RestartClick()
    {
        PausePanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HomeClick()
    {
        PausePanel.SetActive(false);
        MainMenu.SetActive(true);
    }
}
