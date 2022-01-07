using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash_Go_Home_Button_01 : MonoBehaviour {

    public Cha_Grow_Up Cha_Grow_Up_Script_;
    public Fridge_Manager Fridge_Man_Script;
    public Sound_Manager Sound_Man_Script;

    public bool is_Button_Hit = false;
    bool Scale = false;

    public Transform Button_Scale;




    /*
    private void Awake()
    {
        Button_Scale_Up_Down();
    }

    public void Button_Scale_Up_Down()
    {
        StartCoroutine("Up_Down");
    }


    IEnumerator Up_Down()
    {
        if (is_Button_Hit == true)
        {
            Scale = false;
            Button_Scale.localScale = new Vector3(1f, 1f, 1f);
            yield break;
        }

        else if(Scale == false)
        {
            Scale = true;
            Button_Scale.localScale = new Vector3(1.1f, 1.1f, 1.1f);
        }
        else if (Scale == true)
        {
            Scale = false;
            Button_Scale.localScale = new Vector3(1f, 1f, 1f);
        }

        yield return new WaitForSeconds(0.5f);

        StartCoroutine("Up_Down");
    }
    */



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
        Sound_Man_Script.Loof_Stop_Box_Cha_IS_Trash_01();
    }
}
