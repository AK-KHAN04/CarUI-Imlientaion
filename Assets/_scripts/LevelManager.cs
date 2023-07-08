using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] Cars;
    public GameObject[] Levels;
    public int level;
    // Start is called before the first frame update
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        Cars[level - 1].SetActive(true);
        Levels[level - 1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
