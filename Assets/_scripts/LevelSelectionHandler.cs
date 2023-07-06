using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionHandler : MonoBehaviour
{
    public GameObject LevelSelection;
    public Text pos1, pos2, pos3, pos4;
    public int level;
    public Button nextbtn, prevbtn;

    private void Start()
    {
        level = int.Parse(pos1.text);
        if(level == 1)
        {
            prevbtn.interactable = false;
        }
    }
    public void LevelButtonClick(Text levelNo)
    {
        int i = int.Parse(levelNo.text);
        PlayerPrefs.SetInt("level", i);
        Debug.Log(PlayerPrefs.GetInt("level"));
        LevelSelection.SetActive(false);
        MainMenHandler.instance.CarSelection.SetActive(true);
    }

    public void BackClick()
    {
        LevelSelection.SetActive(false);
        MainMenHandler.instance.MainMenu.SetActive(true);
    }

    public void SelectClick()
    {
        LevelSelection.SetActive(false);
        MainMenHandler.instance.CarSelection.SetActive(true);
    }

    public void Next()
    {
        pos1.text = (level+1).ToString();
        pos2.text = (level+2).ToString();
        pos3.text = (level+3).ToString();
        pos4.text = (level+4).ToString();
        level++;
        if(level > 1)
        {
            prevbtn.interactable = true;
        }
        
    }

    public void Previous()
    {
        if(level == 2)
        {
            prevbtn.interactable = false;
        }
        pos1.text = (level - 1).ToString();
        pos2.text = (level ).ToString();
        pos3.text = (level + 1).ToString();
        pos4.text = (level + 2).ToString();
        level--;
    }
}
