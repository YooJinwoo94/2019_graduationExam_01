using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class End_Scene_Manager : MonoBehaviour {

    public Status_Manager Status_Man_Script;
    public Player_Happy_Manager Player_Happy_Man_Script;
    public Sound_Manager Sound_Man_Script;

    public UIPanel End_Scene_UI_Panel;

    public UIPanel Star_Panel_01;
    public UIPanel Star_Panel_02;
    public UIPanel Star_Panel_03;

    public UILabel Left_Money_UI_Label;
    public UILabel people_Happy_Persent_UI_Label;

    public Main_Cam _Main_Cam_Script;

    public UIPanel Good__Panel;
    public UIPanel Great__Panel;
    public UIPanel Excellent__Panel;

    private int x = 0;
    private int y = 0;

    public ParticleSystem[] PopUp_Particle;


    private void Awake()
    {
        Excellent__Panel.alpha = 0f;
        Great__Panel.alpha = 0f;
        Good__Panel.alpha = 0f;

        End_Scene_UI_Panel.alpha = 0f;

        Left_Money_UI_Label.text = "";
        people_Happy_Persent_UI_Label.text = "";

        Star_Panel_Reset();
    }





    // 씬 보여주기 
    public void Pop_Up_End_Scene ()
    {
        Sound_Man_Script.Turn_Off_BGM_Sound = true;
        Sound_Stop();
        Sound_Man_Script.Play_Stage_Clear();

        IS_IT_Good_Or_Ex();
        
        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = true;

        End_Scene_UI_Panel.alpha = 1f;

        Invoke("Count_people_Happy_Persent", 1f);
        Invoke("Count_Left_Money", 1.5f);
        
        Invoke("Pop_Up_Star", 2.5f);
    }





    public void IS_IT_Good_Or_Ex()
    {
        y = System.Convert.ToInt32(Player_Happy_Man_Script.Player_Happy_Count.text);
        if (y >= 26)
        {
            Excellent__Panel.alpha = 1f;
        }
        else if (y >= 13 && y <= 25)
        {
            Great__Panel.alpha = 1f;
        }
        else if (y <= 12)
        {
            Good__Panel.alpha = 1f;
        }
    }



    public void Sound_Stop()
    {
        Sound_Man_Script.Stop_bgm_Basic_Main();
        Sound_Man_Script.Stop_bgm_Frige_Main();
        Sound_Man_Script.Stop_Escape_Sound();

        Sound_Man_Script.Stop_Shower_01();
        Sound_Man_Script.Stop_Shower_02();
        Sound_Man_Script.Stop_Shower_03();
        Sound_Man_Script.Stop_Shower_04();
        Sound_Man_Script.Stop_Shower_05();
        Sound_Man_Script.Stop_Shower_06();
        Sound_Man_Script.Stop_Shower_07();
        Sound_Man_Script.Stop_Shower_08();
        Sound_Man_Script.Stop_Shower_09();
        Sound_Man_Script.Stop_Shower_10();
        Sound_Man_Script.Stop_Shower_11();
        Sound_Man_Script.Stop_Shower_12();

        Sound_Man_Script.Stop_Exercise_01();
        Sound_Man_Script.Stop_Exercise_02();
        Sound_Man_Script.Stop_Exercise_03();
        Sound_Man_Script.Stop_Exercise_04();
        Sound_Man_Script.Stop_Exercise_05();
        Sound_Man_Script.Stop_Exercise_06();
        Sound_Man_Script.Stop_Exercise_07();
        Sound_Man_Script.Stop_Exercise_08();
        Sound_Man_Script.Stop_Exercise_09();
        Sound_Man_Script.Stop_Exercise_10();
        Sound_Man_Script.Stop_Exercise_11();
        Sound_Man_Script.Stop_Exercise_12();

        Sound_Man_Script.Stop_Sleep_01();
        Sound_Man_Script.Stop_Sleep_02();
        Sound_Man_Script.Stop_Sleep_03();
        Sound_Man_Script.Stop_Sleep_04();
        Sound_Man_Script.Stop_Sleep_05();
        Sound_Man_Script.Stop_Sleep_06();
        Sound_Man_Script.Stop_Sleep_07();
        Sound_Man_Script.Stop_Sleep_08();
        Sound_Man_Script.Stop_Sleep_09();
        Sound_Man_Script.Stop_Sleep_10();
        Sound_Man_Script.Stop_Sleep_11();
        Sound_Man_Script.Stop_Sleep_12();

        Sound_Man_Script.Stop_Sleep_01();
        Sound_Man_Script.Stop_Sleep_02();
        Sound_Man_Script.Stop_Sleep_03();
        Sound_Man_Script.Stop_Sleep_04();
        Sound_Man_Script.Stop_Sleep_05();
        Sound_Man_Script.Stop_Sleep_06();
        Sound_Man_Script.Stop_Sleep_07();
        Sound_Man_Script.Stop_Sleep_08();
        Sound_Man_Script.Stop_Sleep_09();
        Sound_Man_Script.Stop_Sleep_10();
        Sound_Man_Script.Stop_Sleep_11();
        Sound_Man_Script.Stop_Sleep_12();

        Sound_Man_Script.Stop_Box_Loop_Sound_01();
        Sound_Man_Script.Stop_Box_Loop_Sound_02();
        Sound_Man_Script.Stop_Box_Loop_Sound_03();
        Sound_Man_Script.Stop_Box_Loop_Sound_04();
        Sound_Man_Script.Stop_Box_Loop_Sound_05();
        Sound_Man_Script.Stop_Box_Loop_Sound_06();
        Sound_Man_Script.Stop_Box_Loop_Sound_07();
        Sound_Man_Script.Stop_Box_Loop_Sound_08();
        Sound_Man_Script.Stop_Box_Loop_Sound_09();
        Sound_Man_Script.Stop_Box_Loop_Sound_10();
        Sound_Man_Script.Stop_Box_Loop_Sound_11();
        Sound_Man_Script.Stop_Box_Loop_Sound_12();

        Sound_Man_Script.Loop_Stop_Frige_Loading_BGM_01();
        Sound_Man_Script.Loop_Stop_Frige_Loading_BGM_02();
        Sound_Man_Script.Loop_Stop_Frige_Loading_BGM_03();
        Sound_Man_Script.Loop_Stop_Frige_Loading_BGM_04();
    }


    // 시간정지 
    private void Time_Stop()
    {
        Time.timeScale = 0f;
        Time.fixedDeltaTime = 0.2f * Time.timeScale;      
    }



    // 남은 금액 계산 
    private void Count_Left_Money()
    {
        Left_Money_UI_Label.text = Status_Man_Script.Money_Label.text;
    }
     // 행복도 계산 
    private void Count_people_Happy_Persent()
    {
        people_Happy_Persent_UI_Label.text = Player_Happy_Man_Script.Player_Happy_Count.text;
        x = System.Convert.ToInt32(people_Happy_Persent_UI_Label.text);
    }


    // 스타의 팝업 조절 
    private void Pop_Up_Star ()
    {
        if (x >= 31)
        {
            Invoke("Star_Open_01", 0.5f);
            Invoke("Star_Open_02", 1f);
            Invoke("Star_Open_03", 1.5f);
        }
          else  if (x >= 21 && x <= 30)
        {
            Invoke("Star_Open_01", 0.5f);
            Invoke("Star_Open_02", 1f);
        }
          else  if (x <= 20)
        {
            Invoke("Star_Open_01", 0.5f);
        }
        Invoke("Time_Stop", 2.0f);
    }



    // 1스타 오픈 
    private void Star_Open_01()
    {
        Star_Panel_01.alpha = 1f;
    }
    // 2스타 오픈 
    private void Star_Open_02()
    {
        Star_Panel_02.alpha = 1f;
    }
    // 3스타 오픈 
    private void Star_Open_03()
    {
        Star_Panel_03.alpha = 1f;
    }



    private void Star_Panel_Reset()
    {
        Star_Panel_01.alpha = 0f;
        Star_Panel_02.alpha = 0f;
        Star_Panel_03.alpha = 0f;
    }



    public void Go_Main_Button()
    {
        Sound_Man_Script.Play_Button_Click();
        SceneManager.LoadScene("Title_Scene");
    }
    public void Go_Next_Button()
    {
        Sound_Man_Script.Play_Button_Click();
    }
    public void Exit_Button()
    {
        Sound_Man_Script.Play_Button_Click();
        Application.Quit();
    }
}
