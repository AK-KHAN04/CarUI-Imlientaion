using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotEnoughHandler : MonoBehaviour
{
    public GameObject NotEnoughCash, MainMenu,Store;

    public void Cancelclick()
    {
        NotEnoughCash.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void StoreClick()
    {
        NotEnoughCash.SetActive(false);
        Store.SetActive(true);
    }
}
