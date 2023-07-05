using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteHandler : MonoBehaviour
{
    public GameObject MainMenu,levelComplete;

    public void HomeClick()
    {
        levelComplete.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void RestartClick()
    {
        levelComplete.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
