using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public static MenuController instance;

    private void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void PlayGame()
    {
        SceneFader.instance.FadeIn ("Scene_001");
        Debug.Log("Button is pressed");
    }
}
