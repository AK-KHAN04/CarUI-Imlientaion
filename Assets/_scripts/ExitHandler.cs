using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitHandler : MonoBehaviour
{
    public GameObject MainMenu, Exit;

    public void YesClick()
    {
        Application.Quit();
    }

    public void NoClick()
    {
        Exit.SetActive(false);
        MainMenu.SetActive(true);
    }
}
