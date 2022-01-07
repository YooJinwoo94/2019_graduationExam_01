using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frige_Button_Con_04 : MonoBehaviour {

    public UIPanel Frige_Button_Panel;
    public UIPanel Frige_Gage_Bar_Panel;
    public UISprite Frige_Gage_Bar_Sprite;

    public Fridge_Manager Fridge_Man_Script;
    public Alart_Manager Alart_Man_Script;
    public Get_Out_Trash_Cha_Manager Get_Out_Trash_Cha_Man_Script;
    public Sound_Manager Sound_Man_Script;

    public BoxCollider Cha_Button_Box_Collider;

    static int Time_Flow_Counter;
    static int Escape_Time_Flow_Count;

    public bool IS_Button_Click = false;




    public void Awake()
    {
        Frige_Button_Panel.alpha = 1f;
        Time_Flow_Counter = 0;
        Escape_Time_Flow_Count = 0;

        Frige_Gage_Bar_Panel.alpha = 0f;
    }







    // 캐릭터 누를시 호출되는 함수
    public void Button_On()
    {
    
    }
    // 캐릭터 누를시 호출되는 함수



    //  냉동 버튼 클릭시 발동 
    public void Frige_Button_Click()
    {
        //사운드
        Sound_Man_Script.Loop_Play_Frige_Loading_BGM_04();

        Fridge_Man_Script.Freeze_Ani_04();

        Frige_Button_Panel.alpha = 0f;
        Frige_Gage_Bar_Panel.alpha = 1f;
        Cha_Button_Box_Collider.enabled = false;

        IS_Button_Click = true;

        StartCoroutine("Move_Frige_Gage_Bar");
    }
    //  냉동 버튼 클릭시 발동 




    //  냉동이 풀렸을때 초기화 
    private void Reset_Frige_Set()
    {
        Frige_Button_Panel.alpha = 1f;
        Frige_Gage_Bar_Panel.alpha = 0f;
        Frige_Gage_Bar_Sprite.fillAmount = 1;
        Time_Flow_Counter = 0;
        Cha_Button_Box_Collider.enabled = true;
        Escape_Time_Flow_Count = 0;
    }
    //   냉동이 풀렸을때 초기화 





    //  냉동시간이 끝나고 발동하는 카운트 다운 

    public void Time_Count_For_Escape()
    {
        //사운드
        Sound_Man_Script.Loop_Stop_Frige_Loading_BGM_04();
        StartCoroutine("Time_Count_For_Escape_Time");
    }

    //  냉동시간이 끝나고 발동하는 카운트 다운 



    //  쓰레기가 도망갈때 초기화 
    public void Reset_Panel_Sprite()
    {
        Fridge_Man_Script.Ani_Enabled_False_04();
        Fridge_Man_Script.Fridge_Sprite_04.spriteName = "None";
        Fridge_Man_Script.Fridge_Cha_Panel_04.alpha = 0f;

        Reset_Frige_Set();
    }
    //  쓰레기가 도망갈때 초기화 




    // 다음 냉동을 기다리는 아이의 카운트 다운 
    IEnumerator Time_Count_For_Escape_Time()
    {
        Debug.Log("aa");
        if (Escape_Time_Flow_Count == 12)
        {
            Debug.Log("aasa");
            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]가 도망쳤습니다.");

            Reset_Panel_Sprite();


            Get_Out_Trash_Cha_Man_Script.Is_Trash_Cha_Here();

            yield break;
        }
        else if (Escape_Time_Flow_Count == 7)
        {
            Debug.Log("aaa");
            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]를 얼려주세요");
        }

        else if (IS_Button_Click == true)
        {
            Debug.Log("aasaaa");
            Escape_Time_Flow_Count = 0;

            IS_Button_Click = false;
            yield break;
        }


        Escape_Time_Flow_Count++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_For_Escape_Time");
    }


    // 냉동 게이지바 타임 카운트 
    IEnumerator Move_Frige_Gage_Bar()
    {
        if (Time_Flow_Counter == 30)
        {
            Reset_Frige_Set();
            Alart_Man_Script.Set_Alart("[8ACE19]냉동[-]이 풀렸습니다.");

            IS_Button_Click = false;

            Fridge_Man_Script.Normal_Ani_04();

            Time_Count_For_Escape();

            yield break;
        }
        else if (Time_Flow_Counter == 20)
        {
            Alart_Man_Script.Set_Alart("곧 [8ACE19]냉동[-]이 풀립니다.");
        }
       
        Time_Flow_Counter++;
        Frige_Gage_Bar_Sprite.fillAmount -= 0.03f;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Move_Frige_Gage_Bar");
    }
}
