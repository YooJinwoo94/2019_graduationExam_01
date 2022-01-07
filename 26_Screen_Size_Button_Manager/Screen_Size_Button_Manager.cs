using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Size_Button_Manager : MonoBehaviour {

    public UIPanel Check_Panel;
    private bool is__Window_Mode;

    public Sound_Manager Sound_Man_Script;





    private void Awake()
    {
        Check_Panel.alpha = 0f;
    }

    public void Check_Window_Mode()
    {
        if(is__Window_Mode == false)
        {
            Sound_Man_Script.Play_Button_Click();

            Check_Panel.alpha = 1f;
            is__Window_Mode = true;
            Window_On();
        }
        else if (is__Window_Mode == true)
        {
            Sound_Man_Script.Play_Button_Click();

            Check_Panel.alpha = 0f;
            is__Window_Mode = false;
            Window_Off();
        }
    }


    public void Window_On()
    {
        Screen.fullScreen = false;
    }

    public void Window_Off()
    {
        Screen.fullScreen = true;
    }
}
