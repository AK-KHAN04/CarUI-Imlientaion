using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashStoreHandler : MonoBehaviour
{

    public GameObject MainMenu, CashStore;

    public void BuyClick()
    {
        CashStore.SetActive(false);
        MainMenu.SetActive(true);
    }
}
