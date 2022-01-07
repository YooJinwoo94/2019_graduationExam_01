using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Out_Trash_Cha_Manager : MonoBehaviour {

    //냉동고로 보내기위한 Panel
    public UIPanel[] Go_To_Frige_Button_Label;
    // 카운트 다운 판넬
    public UIPanel[] Count_Down_Panel;
    // 캐릭터의 판넬 
    public UIPanel[] Trash_Cha_Panel;
    // 버튼의 판넬 
    public UIPanel[] Trash_Cha_Button_Panel;

    // 캐릭터의 애니매이션 작동 및 설정온  
    public UISpriteAnimation[] UISpriteAni;

    //10초동안 터치 비활성화
    public BoxCollider[] Trash_Cha_BoxCollider;

    public UISprite[] Count_Down;
    public UISprite[] Cha_Sprite;
    public UISprite[] Stress_Bar_Sprite;

    static int Time_Flow_Counter_01;
    static int Time_Flow_Counter_02;
    static int Time_Flow_Counter_03;
    static int Time_Flow_Counter_04;

    bool is_Trash_Cha_Here_01;
    bool is_Trash_Cha_Here_02;
    bool is_Trash_Cha_Here_03;
    bool is_Trash_Cha_Here_04;

    public Box_Change_Manager Box_Change_Man_Script;

    public Cha_Grow_Up Cha_Grow_Up_Man_Script_01;
    public Cha_Grow_Up_02 Cha_Grow_Up_Man_Script_02;
    public Cha_Grow_Up_03 Cha_Grow_Up_Man_Script_03;
    public Cha_Grow_Up_04 Cha_Grow_Up_Man_Script_04;
    public Cha_Grow_Up_05 Cha_Grow_Up_Man_Script_05;
    public Cha_Grow_Up_06 Cha_Grow_Up_Man_Script_06;
    public Cha_Grow_Up_07 Cha_Grow_Up_Man_Script_07;
    public Cha_Grow_Up_08 Cha_Grow_Up_Man_Script_08;
    public Cha_Grow_Up_09 Cha_Grow_Up_Man_Script_09;
    public Cha_Grow_Up_10 Cha_Grow_Up_Man_Script_10;
    public Cha_Grow_Up_11 Cha_Grow_Up_Man_Script_11;
    public Cha_Grow_Up_12 Cha_Grow_Up_Man_Script_12;

    public ParticleSystem[] Debuff_Particle;
    public ParticleSystem[] Pop_Up_Trash_Cha_On;

    public Particle_Manager Particle_Man_Script;









    private void Start()
    {
        StartCoroutine("Debuff");

        Go_To_Frige_Button_Label[0].alpha = 0;
        Go_To_Frige_Button_Label[1].alpha = 0;
        Go_To_Frige_Button_Label[2].alpha = 0;
        Go_To_Frige_Button_Label[3].alpha = 0;

        is_Trash_Cha_Here_01 = true;
        is_Trash_Cha_Here_02 = false;
        is_Trash_Cha_Here_03 = false;
        is_Trash_Cha_Here_04 = false;

        Time_Flow_Counter_01 = 0;
        Time_Flow_Counter_02 = 0;
        Time_Flow_Counter_03 = 0;
        Time_Flow_Counter_04 = 0;

        /*
        Trash_Cha_BoxCollider[0].enabled = false;
        Trash_Cha_BoxCollider[1].enabled = false;
        Trash_Cha_BoxCollider[2].enabled = false;
        Trash_Cha_BoxCollider[3].enabled = false;
        */

        UISpriteAni[0].enabled = false;
        UISpriteAni[1].enabled = false;
        UISpriteAni[2].enabled = false;
        UISpriteAni[3].enabled = false;

        Trash_Cha_Panel[0].alpha = 0f;
        Trash_Cha_Panel[1].alpha = 0f;
        Trash_Cha_Panel[2].alpha = 0f;
        Trash_Cha_Panel[3].alpha = 0f;

        Trash_Cha_Button_Panel[0].alpha = 0f;
        Trash_Cha_Button_Panel[1].alpha = 0f;
        Trash_Cha_Button_Panel[2].alpha = 0f;
        Trash_Cha_Button_Panel[3].alpha = 0f;
    }











    public Trash_Cha_Con_01 Trash_Cha_Con_01_Script;
    public Trash_Cha_Con_02 Trash_Cha_Con_02_Script;
    public Trash_Cha_Con_03 Trash_Cha_Con_03_Script;
    public Trash_Cha_Con_04 Trash_Cha_Con_04_Script;

    public Sound_Manager Sound_Man_Script;



    //1
    /// //////////////////////////////////////////////// 캐릭터 여기다 만들어도 되니?
    public void Is_Trash_Cha_Here()
    {
        if (Trash_Cha_Panel[0].alpha == 0f)
        {
            Trash_Cha_Con_01_Script.Trash_Cha_Move = true;
            Trash_Cha_Con_01_Script.Turn_On_Move();

            // 생성 
            Trash_Cha_Panel[0].alpha = 1f;

            Trash_Cha_BoxCollider[0].enabled = true;

            Trash_Cha_Ani_Setting_01();

            //==================================================================== 파티클 
            Debuff_Particle_On_01();
            Trash_Cha_Pop_Up_On_01();

            

            // 사운드
            StartCoroutine("Time_Count_10_01");
        }
        else if (Trash_Cha_Panel[1].alpha == 0f)
        {
            Trash_Cha_Con_02_Script.Trash_Cha_Move = true;
            Trash_Cha_Con_02_Script.Turn_On_Move();

            // 생성 
            Trash_Cha_Panel[1].alpha = 1f;

            Trash_Cha_BoxCollider[1].enabled = true;

            Trash_Cha_Ani_Setting_02();

            //==================================================================== 파티클 
            Debuff_Particle_On_02();
            Trash_Cha_Pop_Up_On_02();

            StartCoroutine("Time_Count_10_02");
        }
        else if (Trash_Cha_Panel[2].alpha == 0f)
        {
            Trash_Cha_Con_03_Script.Trash_Cha_Move = true;
            Trash_Cha_Con_03_Script.Turn_On_Move();

            // 생성 
            Trash_Cha_Panel[2].alpha = 1f;

            Trash_Cha_BoxCollider[2].enabled = true;

            Trash_Cha_Ani_Setting_03();

            //==================================================================== 파티클 
            Debuff_Particle_On_03();
            Trash_Cha_Pop_Up_On_03();

            StartCoroutine("Time_Count_10_03");
        }
        else if (Trash_Cha_Panel[3].alpha == 0f)
        {
            Trash_Cha_Con_04_Script.Trash_Cha_Move = true;
            Trash_Cha_Con_04_Script.Turn_On_Move();

            // 생성 
            Trash_Cha_Panel[3].alpha = 1f;

            Trash_Cha_BoxCollider[3].enabled = true;

            Trash_Cha_Ani_Setting_04();

            //==================================================================== 파티클 
            Debuff_Particle_On_04();
            Trash_Cha_Pop_Up_On_04();

            StartCoroutine("Time_Count_10_04");
        }
        // 사운드 
        Sound_Man_Script.Play_Escape_Sound();
    }
    /////////////////////////////////////////////////// 캐릭터 여기다 만들어도 되니?





    //2
    /////////////////////////////////////////////////// 쓰레기의 애니메이션 설정
    public void Trash_Cha_Ani_Setting_01()
    {
        
         UISpriteAni[0].enabled = true;
         UISpriteAni[0].namePrefix = "Trash_Idle_";         
         UISpriteAni[0].framesPerSecond = 6;
        
    }
    public void Trash_Cha_Ani_Setting_02()
    {
        
         UISpriteAni[1].enabled = true;
         UISpriteAni[1].namePrefix = "Trash_Idle_";
        UISpriteAni[1].framesPerSecond = 6;
        
    }
    public void Trash_Cha_Ani_Setting_03()
    {
        
         UISpriteAni[2].enabled = true;
         UISpriteAni[2].namePrefix = "Trash_Idle_";
        UISpriteAni[2].framesPerSecond = 6;
        
    }
    public void Trash_Cha_Ani_Setting_04()
    {
        
         UISpriteAni[3].enabled = true;
         UISpriteAni[3].namePrefix = "Trash_Idle_";
        UISpriteAni[3].framesPerSecond = 6;
        
    }
    /////////////////////////////////////////////////// 쓰레기의 애니메이션 설정


// ============================================================ 쓰레기 애니메이션 비활성화 
    public void Trash_Cha_Ani_Setting_01_Off()
    {
        UISpriteAni[0].enabled = false;
    }
    public void Trash_Cha_Ani_Setting_02_Off()
    {
        UISpriteAni[1].enabled = false;
    }
    public void Trash_Cha_Ani_Setting_03_Off()
    {
        UISpriteAni[2].enabled = false;
    }
    public void Trash_Cha_Ani_Setting_04_Off()
    {
        UISpriteAni[3].enabled = false;
    }
    // ============================================================ 쓰레기 애니메이션 비활성화 



    // ============================================================ 쓰레기 이동 비활성화 
    public void Trash_Cha_Stop_01 ()
    {
        Trash_Cha_Con_01_Script.Trash_Cha_Move = false;
    }
    public void Trash_Cha_Stop_02()
    {
        Trash_Cha_Con_02_Script.Trash_Cha_Move = false;
    }
    public void Trash_Cha_Stop_03()
    {
        Trash_Cha_Con_03_Script.Trash_Cha_Move = false;
    }
    public void Trash_Cha_Stop_04()
    {
        Trash_Cha_Con_04_Script.Trash_Cha_Move = false;
    }
    // ============================================================ 쓰레기 이동 비활성화 







    //3  파티클 
    /////////////////////////////////////////////////// 캐릭터 디버프 



    //===================================================================  등장 파티클 온 
    public void Trash_Cha_Pop_Up_On_01()
    {
        Pop_Up_Trash_Cha_On[0].Play(true);
    }
    public void Trash_Cha_Pop_Up_On_02()
    {
        Pop_Up_Trash_Cha_On[1].Play(true);
    }
    public void Trash_Cha_Pop_Up_On_03()
    {
        Pop_Up_Trash_Cha_On[2].Play(true);
    }
    public void Trash_Cha_Pop_Up_On_04()
    {
        Pop_Up_Trash_Cha_On[3].Play(true);
    }
    //=================================================================== 등장 파티클 온 


    //=================================================================== 캐릭터 해골 파티클 온
    public void Debuff_Particle_On_01()
    {
        Debuff_Particle[0].Play(true);
    }
    public void Debuff_Particle_On_02()
    {
        Debuff_Particle[1].Play(true);
    }
    public void Debuff_Particle_On_03()
    {
        Debuff_Particle[2].Play(true);
    }
    public void Debuff_Particle_On_04()
    {
        Debuff_Particle[3].Play(true);
    }
    //=================================================================== 캐릭터 해골 파티클 온
    //=================================================================== 캐릭터 해골 파티클 오프 
    public void Debuff_Particle_Off_01()
    {
        Debuff_Particle[0].Stop(true);
    }
    public void Debuff_Particle_Off_02()
    {
        Debuff_Particle[1].Stop(true);
    }
    public void Debuff_Particle_Off_03()
    {
        Debuff_Particle[2].Stop(true);
    }
    public void Debuff_Particle_Off_04()
    {
        Debuff_Particle[3].Stop(true);
    }
    //=================================================================== 캐릭터 해골 파티클 오프 

    /////////////////////////////////////////////////// 캐릭터 디버프 







    //4
    /////////////////////////////////////////////////// 캐릭터를 눌러서    // 버튼 판넬 온 
    public void If_Click_Trash_Cha_01()
    {
        Trash_Cha_Button_Panel[0].alpha = 1f;
    }
    public void If_Click_Trash_Cha_02()
    {
        Trash_Cha_Button_Panel[1].alpha = 1f;
    }
    public void If_Click_Trash_Cha_03()
    {
        Trash_Cha_Button_Panel[2].alpha = 1f;
    }
    public void If_Click_Trash_Cha_04()
    {
        Trash_Cha_Button_Panel[3].alpha = 1f;
    }
    /////////////////////////////////////////////////// 캐릭터를 눌러서    // 버튼 판넬 온 






   // Debuff_Off

/////////////////////////////////////////////////// 코루틴
  IEnumerator Debuff()
    {
        //============================================================================================================================================= 1개라도 있으면 디버프 온 + 빈 박스이면 Pass
        if (Trash_Cha_Panel[0].alpha == 1f || Trash_Cha_Panel[1].alpha == 1f || Trash_Cha_Panel[2].alpha == 1f || Trash_Cha_Panel[3].alpha == 1f)
        {
            for (int i = 0; i < 12; i++)
            {
                if (Box_Change_Man_Script.Box_UI_Sprite[i].spriteName != Box_Change_Man_Script.Num_Box_BG_00)
                {
                    //1
                    if(i==0)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if(Cha_Grow_Up_Man_Script_01.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_01.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[0].fillAmount = Cha_Grow_Up_Man_Script_01.Cha_Stress_Bar_Float;
                        }                     
                    }
                    //2
                    if (i == 1)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_02.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_02.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[1].fillAmount = Cha_Grow_Up_Man_Script_02.Cha_Stress_Bar_Float;
                        }
                    }
                    //3
                    if (i == 2)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_03.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_03.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[2].fillAmount = Cha_Grow_Up_Man_Script_03.Cha_Stress_Bar_Float;
                        }
                    }
                    //4
                    if (i == 3)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_04.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_04.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[3].fillAmount = Cha_Grow_Up_Man_Script_04.Cha_Stress_Bar_Float;
                        }
                    }
                    //5
                    if (i == 4)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_05.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_05.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[4].fillAmount = Cha_Grow_Up_Man_Script_05.Cha_Stress_Bar_Float;
                        }
                    }
                    //6
                    if (i == 5)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_06.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_06.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[5].fillAmount = Cha_Grow_Up_Man_Script_06.Cha_Stress_Bar_Float;
                        }
                    }
                    //7
                    if (i == 6)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_07.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_07.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[6].fillAmount = Cha_Grow_Up_Man_Script_07.Cha_Stress_Bar_Float;
                        }
                    }
                    //8
                    if (i == 7)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_08.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_08.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[7].fillAmount = Cha_Grow_Up_Man_Script_08.Cha_Stress_Bar_Float;
                        }
                    }
                    //9
                    if (i == 8)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_09.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_09.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[8].fillAmount = Cha_Grow_Up_Man_Script_09.Cha_Stress_Bar_Float;
                        }
                    }
                    //10
                    if (i == 9)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_10.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_10.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[9].fillAmount = Cha_Grow_Up_Man_Script_10.Cha_Stress_Bar_Float;
                        }
                    }
                    //11
                    if (i == 10)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_11.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_11.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[10].fillAmount = Cha_Grow_Up_Man_Script_11.Cha_Stress_Bar_Float;
                        }
                    }
                    //12
                    if (i == 11)
                    {
                        Particle_Man_Script.Particle_Debuff_Cha_On(i);

                        if (Cha_Grow_Up_Man_Script_12.Cha_Stress_Bar_Float <= 0.8f)
                        {
                            Cha_Grow_Up_Man_Script_12.Cha_Stress_Bar_Float += 0.02f;
                            Stress_Bar_Sprite[11].fillAmount = Cha_Grow_Up_Man_Script_12.Cha_Stress_Bar_Float;
                        }
                    }
                }
            }
        }

        //============================================================================================================================================= 쓰레기 애들이 1개라도 없으면
        if (Trash_Cha_Panel[0].alpha == 0f && Trash_Cha_Panel[1].alpha == 0f && Trash_Cha_Panel[2].alpha == 0f && Trash_Cha_Panel[3].alpha == 0f)
        {
            for (int i = 0; i < 12; i++)
            {
                Particle_Man_Script.Particle_Debuff_Cha_Off(i);
            }
        }

        //============================================================================================================================================== 해당 쓰레기가 사라져 있다면 비활성화 하기 
        for (int i = 0; i < 4; i++)
        {
           if (Trash_Cha_Panel[i].alpha == 0f)
            {
                if(i == 0)
                {
                    Trash_Cha_Ani_Setting_01_Off();
                    Trash_Cha_Stop_01();
                }
               if (i == 1)
                {
                    Trash_Cha_Ani_Setting_02_Off();
                    Trash_Cha_Stop_02();
                }
               if (i == 2)
                {
                    Trash_Cha_Ani_Setting_03_Off();
                    Trash_Cha_Stop_03();
                }
                if (i == 1)
                {
                    Trash_Cha_Ani_Setting_04_Off();
                    Trash_Cha_Stop_04();
                }
            }
        }

        //============================================================================================================================================== 박스가 비활성화 상태이면 파티클 오프 
        for (int i = 0; i < 12; i++)
        {
            if ( Box_Change_Man_Script.Box_UI_Sprite[i].spriteName == "Box_BG_00" )
            {
                Particle_Man_Script.Particle_Debuff_Cha_Off(i);
            }        
        }

        // ============================================================================================================================================== 쓰레기 상태이면 디버프 파티클 오프 
        if (Cha_Grow_Up_Man_Script_01.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(0);
        }
        if (Cha_Grow_Up_Man_Script_02.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(1);
        }
        if (Cha_Grow_Up_Man_Script_03.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(2);
        }
        if (Cha_Grow_Up_Man_Script_04.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(3);
        }
        if (Cha_Grow_Up_Man_Script_05.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(4);
        }
        if (Cha_Grow_Up_Man_Script_06.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(5);
        }
        if (Cha_Grow_Up_Man_Script_07.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(6);
        }
        if (Cha_Grow_Up_Man_Script_08.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(7);
        }
        if (Cha_Grow_Up_Man_Script_09.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(8);
        }
        if (Cha_Grow_Up_Man_Script_10.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(9);
        }
        if (Cha_Grow_Up_Man_Script_11.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(10);
        }
        if (Cha_Grow_Up_Man_Script_12.Cha_Stress_Bar_Float >= 1f)
        {
            Particle_Man_Script.Particle_Debuff_Cha_Off(11);
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Debuff");
    }







    // 타임 카운트_01
    IEnumerator Time_Count_10_01()
    {
        //0
        if (Time_Flow_Counter_01 == 0)
        {
            Count_Down_Panel[0].alpha = 1f;
            //이미지 10
            Count_Down[0].spriteName = "Stage_Gag_10";
        }
        //1
        if (Time_Flow_Counter_01 == 1)
        {
            //이미지 9
            Count_Down[0].spriteName = "Stage_Gag_09";
        }
        //2
        if (Time_Flow_Counter_01 == 2)
        {
            //이미지 8
            Count_Down[0].spriteName = "Stage_Gag_08";
        }
        //3
        if (Time_Flow_Counter_01 == 3)
        {
            //이미지 7
            Count_Down[0].spriteName = "Stage_Gag_07";
        }
        //4
        if (Time_Flow_Counter_01 == 4)
        {
            //이미지 6
            Count_Down[0].spriteName = "Stage_Gag_06";
        }
        //5
        if (Time_Flow_Counter_01 == 5)
        {
            //이미지 5
            Count_Down[0].spriteName = "Stage_Gag_05";
        }
        //6
        if (Time_Flow_Counter_01 == 6)
        {
            //이미지 4
            Count_Down[0].spriteName = "Stage_Gag_04";
        }
        //7
        if (Time_Flow_Counter_01 == 7)
        {
            //이미지 3
            Count_Down[0].spriteName = "Stage_Gag_03";
        }
        //8
        if (Time_Flow_Counter_01 == 8)
        {
            //이미지 2
            Count_Down[0].spriteName = "Stage_Gag_02";
        }
        //9
        if (Time_Flow_Counter_01 == 9)
        {
            //이미지 1
            Count_Down[0].spriteName = "Stage_Gag_01";
        }
        //10
        if (Time_Flow_Counter_01 == 10)
        {
            //이미지 0
            Count_Down[0].spriteName = "Stage_Gag_00";

            // 초기화 
            Time_Flow_Counter_01 = 0;
            // Trash_Go_Home_Button_Script.is_Button_Hit = false;

            Go_To_Frige_Button_Label[0].alpha = 1;
            Count_Down_Panel[0].alpha = 0f;
            //Trash_Cha_BoxCollider[0].enabled = true;

            yield break;
        }


        Time_Flow_Counter_01++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_10_01");
    }

    // 타임 카운트_02
    IEnumerator Time_Count_10_02()
    {
        //0
        if (Time_Flow_Counter_02 == 0)
        {
            Count_Down_Panel[1].alpha = 1f;
            //이미지 10
            Count_Down[1].spriteName = "Stage_Gag_10";
        }
        //1
        if (Time_Flow_Counter_02 == 1)
        {
            //이미지 9
            Count_Down[1].spriteName = "Stage_Gag_09";
        }
        //2
        if (Time_Flow_Counter_02 == 2)
        {
            //이미지 8
            Count_Down[1].spriteName = "Stage_Gag_08";
        }
        //3
        if (Time_Flow_Counter_02 == 3)
        {
            //이미지 7
            Count_Down[1].spriteName = "Stage_Gag_07";
        }
        //4
        if (Time_Flow_Counter_02 == 4)
        {
            //이미지 6
            Count_Down[1].spriteName = "Stage_Gag_06";
        }
        //5
        if (Time_Flow_Counter_02 == 5)
        {
            //이미지 5
            Count_Down[1].spriteName = "Stage_Gag_05";
        }
        //6
        if (Time_Flow_Counter_02 == 6)
        {
            //이미지 4
            Count_Down[1].spriteName = "Stage_Gag_04";
        }
        //7
        if (Time_Flow_Counter_02 == 7)
        {
            //이미지 3
            Count_Down[1].spriteName = "Stage_Gag_03";
        }
        //8
        if (Time_Flow_Counter_02 == 8)
        {
            //이미지 2
            Count_Down[1].spriteName = "Stage_Gag_02";
        }
        //9
        if (Time_Flow_Counter_02 == 9)
        {
            //이미지 1
            Count_Down[1].spriteName = "Stage_Gag_01";
        }
        //10
        if (Time_Flow_Counter_02 == 10)
        {
            //이미지 0
            Count_Down[1].spriteName = "Stage_Gag_00";

            // 초기화 
            Time_Flow_Counter_02 = 0;
            // Trash_Go_Home_Button_Script.is_Button_Hit = false;

            Go_To_Frige_Button_Label[1].alpha = 1;
            Count_Down_Panel[1].alpha = 0f;
            //Trash_Cha_BoxCollider[0].enabled = true;

            yield break;
        }


        Time_Flow_Counter_02++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_10_02");
    }

    // 타임 카운트_03
    IEnumerator Time_Count_10_03()
    {
        //0
        if (Time_Flow_Counter_03 == 0)
        {
            Count_Down_Panel[2].alpha = 1f;
            //이미지 10
            Count_Down[2].spriteName = "Stage_Gag_10";
        }
        //1
        if (Time_Flow_Counter_03 == 1)
        {
            //이미지 9
            Count_Down[2].spriteName = "Stage_Gag_09";
        }
        //2
        if (Time_Flow_Counter_03 == 2)
        {
            //이미지 8
            Count_Down[2].spriteName = "Stage_Gag_08";
        }
        //3
        if (Time_Flow_Counter_03 == 3)
        {
            //이미지 7
            Count_Down[2].spriteName = "Stage_Gag_07";
        }
        //4
        if (Time_Flow_Counter_03 == 4)
        {
            //이미지 6
            Count_Down[2].spriteName = "Stage_Gag_06";
        }
        //5
        if (Time_Flow_Counter_03 == 5)
        {
            //이미지 5
            Count_Down[2].spriteName = "Stage_Gag_05";
        }
        //6
        if (Time_Flow_Counter_03 == 6)
        {
            //이미지 4
            Count_Down[2].spriteName = "Stage_Gag_04";
        }
        //7
        if (Time_Flow_Counter_03 == 7)
        {
            //이미지 3
            Count_Down[2].spriteName = "Stage_Gag_03";
        }
        //8
        if (Time_Flow_Counter_03 == 8)
        {
            //이미지 2
            Count_Down[2].spriteName = "Stage_Gag_02";
        }
        //9
        if (Time_Flow_Counter_03 == 9)
        {
            //이미지 1
            Count_Down[2].spriteName = "Stage_Gag_01";
        }
        //10
        if (Time_Flow_Counter_03 == 10)
        {
            //이미지 0
            Count_Down[2].spriteName = "Stage_Gag_00";

            // 초기화 
            Time_Flow_Counter_03 = 0;
            // Trash_Go_Home_Button_Script.is_Button_Hit = false;

            Go_To_Frige_Button_Label[2].alpha = 1;
            Count_Down_Panel[2].alpha = 0f;
            //Trash_Cha_BoxCollider[0].enabled = true;

            yield break;
        }


        Time_Flow_Counter_03++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_10_03");
    }

    // 타임 카운트_04
    IEnumerator Time_Count_10_04()
    {
        //0
        if (Time_Flow_Counter_04 == 0)
        {
            Count_Down_Panel[3].alpha = 1f;
            //이미지 10
            Count_Down[3].spriteName = "Stage_Gag_10";
        }
        //1
        if (Time_Flow_Counter_04 == 1)
        {
            //이미지 9
            Count_Down[3].spriteName = "Stage_Gag_09";
        }
        //2
        if (Time_Flow_Counter_04 == 2)
        {
            //이미지 8
            Count_Down[3].spriteName = "Stage_Gag_08";
        }
        //3
        if (Time_Flow_Counter_04 == 3)
        {
            //이미지 7
            Count_Down[3].spriteName = "Stage_Gag_07";
        }
        //4
        if (Time_Flow_Counter_04 == 4)
        {
            //이미지 6
            Count_Down[3].spriteName = "Stage_Gag_06";
        }
        //5
        if (Time_Flow_Counter_04 == 5)
        {
            //이미지 5
            Count_Down[3].spriteName = "Stage_Gag_05";
        }
        //6
        if (Time_Flow_Counter_04 == 6)
        {
            //이미지 4
            Count_Down[3].spriteName = "Stage_Gag_04";
        }
        //7
        if (Time_Flow_Counter_04 == 7)
        {
            //이미지 3
            Count_Down[3].spriteName = "Stage_Gag_03";
        }
        //8
        if (Time_Flow_Counter_04 == 8)
        {
            //이미지 2
            Count_Down[3].spriteName = "Stage_Gag_02";
        }
        //9
        if (Time_Flow_Counter_04 == 9)
        {
            //이미지 1
            Count_Down[3].spriteName = "Stage_Gag_01";
        }
        //10
        if (Time_Flow_Counter_04 == 10)
        {
            //이미지 0
            Count_Down[3].spriteName = "Stage_Gag_00";

            // 초기화 
            Time_Flow_Counter_04 = 0;
            // Trash_Go_Home_Button_Script.is_Button_Hit = false;

            Go_To_Frige_Button_Label[3].alpha = 1;
            Count_Down_Panel[3].alpha = 0f;
            //Trash_Cha_BoxCollider[0].enabled = true;

            yield break;
        }


        Time_Flow_Counter_04++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_10_04");
    }
}
