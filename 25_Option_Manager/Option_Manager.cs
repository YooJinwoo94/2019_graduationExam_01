using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_Manager : MonoBehaviour {

    public bool is_Option_On;
    public UIPanel Option_Panel;
    public Sound_Manager Sound_Man_Script;
    public Stop_Manager Stop_Man_Script;
    


    private void Awake()
    {
        Option_Panel.alpha = 0f;
    }


    public void Option_Panel_On()
    {
       Option_Panel.alpha = 1f;
        is_Option_On = true;
    }


    public void Option_Panel_Off()
    {
       Sound_Man_Script.Play_Button_Click();
       Sound_Man_Script.Play_Scene_Change();
       Option_Panel.alpha = 0f;
       Stop_Man_Script.Stop_Panel_On();
        is_Option_On = false;
    }
}
