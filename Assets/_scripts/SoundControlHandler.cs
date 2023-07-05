using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControlHandler : MonoBehaviour
{
    public GameObject MainMenu, soundMenu;

    public void click()
    {
        soundMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
}
