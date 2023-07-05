using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFailHandler : MonoBehaviour
{
    public GameObject MainMenu,levelFail;

    public void HomeClick()
    {
        levelFail.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void RestartClick()
    {
        levelFail.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
