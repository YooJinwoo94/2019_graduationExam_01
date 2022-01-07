using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash_Go_Home_Button_11 : MonoBehaviour {

    public Cha_Grow_Up_11 Cha_Grow_Up_Script_;
    public Fridge_Manager Fridge_Man_Script;
    public Sound_Manager Sound_Man_Script;

    public bool is_Button_Hit = false;

    // 격리 버튼 누르기 
    public void is_Click_Go_Trash_Button_()
    {
        is_Button_Hit = true;

        Cha_Grow_Up_Script_.Reset_Float();
        Cha_Grow_Up_Script_.Boom_Particle();
        Cha_Grow_Up_Script_.Cha_Ani_Off();

        // 격리 버튼 판넬 가리기 
        Cha_Grow_Up_Script_.Trash_Go_Home_Button_Off();

        Cha_Grow_Up_Script_.Con_Trash_Button = false;
        Cha_Grow_Up_Script_.Trash_Button_Off();

        Fridge_Man_Script.Check_Panel_On_Off();

        //사운드
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Loof_Stop_Box_Cha_IS_Trash_11();
    }
}
