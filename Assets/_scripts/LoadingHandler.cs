using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingHandler : MonoBehaviour
{

    public Image slider;
    public Text perc;

    
    // Start is called before the first frame update
    void Start()
    {
       
        perc.text = (slider.fillAmount * 100).ToString();
        StartCoroutine(LoadLevelAsync());
    }

    // Update is called once per frame
    void Update()
    {
                 
    }


    IEnumerator LoadLevelAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1);

        while (!operation.isDone)
        {
            float progressvalue = Mathf.Clamp01(operation.progress / 0.9f);
            
            slider.fillAmount = progressvalue;
            perc.text = (progressvalue*100).ToString();
            Debug.Log(slider.fillAmount*100);
            
            yield return null;
        }
    }
}
