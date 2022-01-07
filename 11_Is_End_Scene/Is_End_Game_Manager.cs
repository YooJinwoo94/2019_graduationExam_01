using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Is_End_Game_Manager : MonoBehaviour {

    public UIPanel Is_End_Game_Panel;


    public void Pop_UP_Is_End_Game_Panel ()
    {
        Is_End_Game_Panel.alpha = 1f;
    }
    public void Close_Is_End_Game_Panel()
    {
        Is_End_Game_Panel.alpha = 0f;
    }

    public void Close_Game()
    {
       // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
