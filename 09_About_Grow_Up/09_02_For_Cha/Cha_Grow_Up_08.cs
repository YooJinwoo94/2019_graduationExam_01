using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cha_Grow_Up_08 : MonoBehaviour {

    public UISprite Cha;
    public UISprite Trash_Count_Down_Sprite;

    public float Cha_Happy_Bar_Float = 0f;
    public float Cha_Stress_Bar_Float = 0f;

    public int Cha_Stress_Count = 0;

    public Cha_Type _Type_Of_Cha;

    public bool Type_A;
    public bool Type_B;
    public bool Type_C;
    public bool Type_D;
    public bool Type_E;
    public bool Type_F;
    public bool Type_G;
    public bool Type_H;
    public bool Type_I;
    public bool Type_J;

    public bool Is_Check_Cha_02;

    public UIPanel Trash_Count_Down_panel;
    public UIPanel Press_Cha_Open_Button;                      // 4개의 육성 버튼 판넬 
    public UIPanel Cha_UI_Panel_All_On_Off;
    public UIPanel Angry_Panel;
    public UIPanel Trash_Go_Home_Panel;

    // 캐릭터 버튼 콜라이더 
    public BoxCollider Cha_Collider;

    public Fridge_Manager Fridge_Man_Script;
    public Particle_Manager Particle_Man_Script;
    public Box_Change_Manager Box_Change_Man_Script;
    public Sound_Manager Sound_Man_Script;
    public Inventory_Manager Inven_Man;

    public Trash_Go_Home_Button_08 Trash_Go_Home_Button_Script;

    public UISprite Happy_Bar_Sprite_01;
    public UISprite Stress_Bar_Sprite_01;

    public UIButton _Cha_02_Change_Normal_Image;

    public UISpriteAnimation _UI_Sprite_Animation;

    public ParticleSystem Dust;
    public GameObject Debuff;

    static int Time_Flow_Counter;

    public bool Con_Grow_Button = false;
    public bool Con_Trash_Button = false;




    //=================================================== 스타트 / 업데이트 함수

    private void Start()
    {
        Trash_Count_Down_panel.alpha = 0f;

        Time_Flow_Counter = 0;
        Press_Cha_Open_Button.alpha = 0f;
    }

    //캐릭터가 일정 수치 이상이면 변신하겠습니다. 
    private void FixedUpdate()
    {
      //  is_Cha_Trash();
    }

    //=================================================== 스타트 / 업데이트 함수








    // 할당되어 있는 캐릭터의 이름을 채크하여 해당 캐릭터의 속성값을 조절한다. 
    public void Check_Cha_Name()
    {
        // 각 아이들이 맞는지 아닌지 확인한다.
        if (Cha.spriteName == "A_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_A;

            Type_A = true;

            Type_B = false;
            Type_C = false;
            Type_D = false;
            Type_E = false;
            Type_F = false;
            Type_G = false;
            Type_H = false;
            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "B_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_B;

            Type_A = false;

            Type_B = true;

            Type_C = false;
            Type_D = false;
            Type_E = false;
            Type_F = false;
            Type_G = false;
            Type_H = false;
            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "C_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_C;

            Type_A = false;
            Type_B = false;

            Type_C = true;

            Type_D = false;
            Type_E = false;
            Type_F = false;
            Type_G = false;
            Type_H = false;
            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "D_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_D;

            Type_A = false;
            Type_B = false;
            Type_C = false;

            Type_D = true;

            Type_E = false;
            Type_F = false;
            Type_G = false;
            Type_H = false;
            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "E_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_E;

            Type_A = false;
            Type_B = false;
            Type_C = false;
            Type_D = false;

            Type_E = true;

            Type_F = false;
            Type_G = false;
            Type_H = false;
            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "F_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_F;

            Type_A = true;
            Type_B = false;
            Type_C = false;
            Type_D = false;
            Type_E = false;

            Type_F = true;

            Type_G = false;
            Type_H = false;
            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "G_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_G;

            Type_A = false;
            Type_B = false;
            Type_C = false;
            Type_D = false;
            Type_E = false;
            Type_F = false;

            Type_G = true;

            Type_H = false;
            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "H_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_H;

            Type_A = false;
            Type_B = false;
            Type_C = false;
            Type_D = false;
            Type_E = false;
            Type_F = false;
            Type_G = false;

            Type_H = true;

            Type_I = false;
            Type_J = false;
        }

        else if (Cha.spriteName == "I_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_I;

            Type_A = false;
            Type_B = false;
            Type_C = false;
            Type_D = false;
            Type_E = false;
            Type_F = false;
            Type_G = false;
            Type_H = false;

            Type_I = true;

            Type_J = false;
        }

        else if (Cha.spriteName == "J_01_Idle_01")
        {
            _Type_Of_Cha = Cha_Type.Like_J;

            Type_A = false;
            Type_B = false;
            Type_C = false;
            Type_D = false;
            Type_E = false;
            Type_F = false;
            Type_G = false;
            Type_H = false;
            Type_I = false;

            Type_J = true;
        }
    }








    //=============================================  버튼 클릭

    //자 이제 캐릭터를 눌러서 수확을 해야해! 
    public void Cha_Click()
    {
        // 완성체일 경우
        if (Cha_Happy_Bar_Float >= 1 && Cha_Stress_Bar_Float <= 1)
        {
            //애니메이션 설정 
            Cha_Ani_Off();

            //======================================================================================================================= A 
            if (Cha.spriteName == "A_03_Idle_01" || Cha.spriteName == "A_03_Idle_02" || Cha.spriteName == "A_03_Idle_03"
                || Cha.spriteName == "A_03_Idle_04" || Cha.spriteName == "A_03_Idle_05" || Cha.spriteName == "A_03_Idle_06"
                || Cha.spriteName == "A_03_Idle_07" || Cha.spriteName == "A_03_Idle_08" || Cha.spriteName == "A_03_Idle_09"
                || Cha.spriteName == "A_03_Idle_10" || Cha.spriteName == "A_03_Idle_11" || Cha.spriteName == "A_03_Idle_12"
                || Cha.spriteName == "A_03_Idle_13" || Cha.spriteName == "A_03_Idle_14" || Cha.spriteName == "A_03_Idle_15" || Cha.spriteName == "A_03_Idle_16")
            {
                Inven_Man.Cha_Name = "A_03_Idle_01";
            }

            //======================================================================================================================= B
            else if (Cha.spriteName == "B_03_Idle_01" || Cha.spriteName == "B_03_Idle_02" || Cha.spriteName == "B_03_Idle_03"
                    || Cha.spriteName == "B_03_Idle_04" || Cha.spriteName == "B_03_Idle_05" || Cha.spriteName == "B_03_Idle_06"
                    || Cha.spriteName == "B_03_Idle_07" || Cha.spriteName == "B_03_Idle_08" || Cha.spriteName == "B_03_Idle_09"
                    || Cha.spriteName == "B_03_Idle_10")
            {
                Inven_Man.Cha_Name = "B_03_Idle_01";
            }

            //======================================================================================================================= C
            else if (Cha.spriteName == "C_03_Idle_01" || Cha.spriteName == "C_03_Idle_02" || Cha.spriteName == "C_03_Idle_03"
                   || Cha.spriteName == "C_03_Idle_04" || Cha.spriteName == "C_03_Idle_05" || Cha.spriteName == "C_03_Idle_06"
                   || Cha.spriteName == "C_03_Idle_07" || Cha.spriteName == "C_03_Idle_08" || Cha.spriteName == "C_03_Idle_09"
                   )
            {
                Inven_Man.Cha_Name = "C_03_Idle_01";
            }

            //======================================================================================================================= D
            else if (Cha.spriteName == "D_03_Idle_01" || Cha.spriteName == "D_03_Idle_02" || Cha.spriteName == "D_03_Idle_03"
                   || Cha.spriteName == "D_03_Idle_04" || Cha.spriteName == "D_03_Idle_05" || Cha.spriteName == "D_03_Idle_06"
                   || Cha.spriteName == "D_03_Idle_07" || Cha.spriteName == "D_03_Idle_08" || Cha.spriteName == "D_03_Idle_09"
                   || Cha.spriteName == "D_03_Idle_10")
            {
                Inven_Man.Cha_Name = "D_03_Idle_01";
            }

            else if (Cha.spriteName == "E_03_Idle_01" || Cha.spriteName == "E_03_Idle_02" || Cha.spriteName == "E_03_Idle_03"
                   || Cha.spriteName == "E_03_Idle_04" || Cha.spriteName == "E_03_Idle_05" || Cha.spriteName == "E_03_Idle_06"
                   || Cha.spriteName == "E_03_Idle_07" || Cha.spriteName == "E_03_Idle_08" || Cha.spriteName == "E_03_Idle_09"
                   || Cha.spriteName == "E_03_Idle_10" || Cha.spriteName == "E_03_Idle_11" || Cha.spriteName == "E_03_Idle_12"
                   || Cha.spriteName == "E_03_Idle_13")
            {
                Inven_Man.Cha_Name = "E_03_Idle_01";
            }

            else if (Cha.spriteName == "F_03_Idle_01")
            {
                Inven_Man.Cha_Name = "F_03_Idle_01";
            }

            //======================================================================================================================= G
            else if (Cha.spriteName == "G_03_Idle_01" || Cha.spriteName == "G_03_Idle_02" || Cha.spriteName == "G_03_Idle_03"
                   || Cha.spriteName == "G_03_Idle_04" || Cha.spriteName == "G_03_Idle_05" || Cha.spriteName == "G_03_Idle_06"
                   || Cha.spriteName == "G_03_Idle_07" || Cha.spriteName == "G_03_Idle_08" || Cha.spriteName == "G_03_Idle_09"
                   || Cha.spriteName == "G_03_Idle_10")
            {
                Inven_Man.Cha_Name = "G_03_Idle_01";
            }

            else if (Cha.spriteName == "H_03_Idle_01")
            {
                Inven_Man.Cha_Name = "H_03_Idle_01";
            }

            else if (Cha.spriteName == "I_03_Idle_01")
            {
                Inven_Man.Cha_Name = "I_03_Idle_01";
            }

            else if (Cha.spriteName == "J_03_Idle_01" || Cha.spriteName == "J_03_Idle_02" || Cha.spriteName == "J_03_Idle_03"
                   || Cha.spriteName == "J_03_Idle_04" || Cha.spriteName == "J_03_Idle_05" || Cha.spriteName == "J_03_Idle_06"
                   || Cha.spriteName == "J_03_Idle_07" || Cha.spriteName == "J_03_Idle_08" || Cha.spriteName == "J_03_Idle_09"
                   || Cha.spriteName == "J_03_Idle_10")
            {
                Inven_Man.Cha_Name = "J_03_Idle_01";
            }

            // 인벤 함수 호출 
            Inven_Man.Inventory_On();

            //육성 버튼 안보이게 하기 
            Press_Cha_Open_Button.alpha = 0f;

            // 폭발 파티클 발동
            Boom_Particle();

            // 수치값 초기화 
            Reset_Float();

            Sound_Man_Script.Play_Get_Food_Put_To_Inven();
            Sound_Man_Script.Stop_Box_Loop_Sound_08();
        }
    }

    // 쓰레기 상태인 경우 버튼을 보이게 해야해! 
    public void is_Cha_Trash_Click()
    {
        if (Cha_Stress_Bar_Float >= 1)
        {
            Trash_Go_Home_Button_On();
        }
    }
    //=============================================  버튼 클릭









    //=============================================  모습 변화
    // 쓰레기 상태인지 확인하기 + 격리 시간 체크 함수 호출 
    public void is_Cha_Trash()
    {
        if (Cha_Stress_Bar_Float >= 1)
        {
            Angry_Panel.alpha = 0f;

            is_Cha_Trash_Click();

            // 사운드 
            Sound_Man_Script.Play_Box_Cha_IS_Trash_08();
            Sound_Man_Script.Loof_Play_Box_Cha_IS_Trash_08();

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
            _UI_Sprite_Animation.namePrefix = "Trash_Idle_";
            _UI_Sprite_Animation.framesPerSecond = 10;
        }
    }

    // 행복도가 일정 수치 이상인지 확인하기 
    public void is_Cha_Can_Change()
    {
        /////////////////////////////////////////////////////////////////////////////////A
        if (_Type_Of_Cha == Cha_Type.Like_A)
        {
            Debug.Log("s");
            if (Cha_Happy_Bar_Float < 0.5f)
            {
                _UI_Sprite_Animation.namePrefix = "A_01_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 0.5f && Cha_Happy_Bar_Float < 1)
            {
                _UI_Sprite_Animation.namePrefix = "A_02_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 1)
            {
                _UI_Sprite_Animation.namePrefix = "A_03_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                Particle_Man_Script.Full_Level_Up_Particle[7].Play(true);

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
        }

        /////////////////////////////////////////////////////////////////////////////////B
        if (_Type_Of_Cha == Cha_Type.Like_B)
        {
            if (Cha_Happy_Bar_Float < 0.5f)
            {
                _UI_Sprite_Animation.namePrefix = "B_01_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 0.5f && Cha_Happy_Bar_Float < 1)
            {
                _UI_Sprite_Animation.namePrefix = "B_02_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 1)
            {
                _UI_Sprite_Animation.namePrefix = "B_03_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                Particle_Man_Script.Full_Level_Up_Particle[7].Play(true);

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
        }

        /////////////////////////////////////////////////////////////////////////////////C
        if (_Type_Of_Cha == Cha_Type.Like_C)
        {
            if (Cha_Happy_Bar_Float < 0.5f)
            {
                _UI_Sprite_Animation.namePrefix = "C_01_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 0.5f && Cha_Happy_Bar_Float < 1)
            {
                _UI_Sprite_Animation.namePrefix = "C_02_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 1)
            {
                _UI_Sprite_Animation.namePrefix = "C_03_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                Particle_Man_Script.Full_Level_Up_Particle[7].Play(true);

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
        }

        //=========================================================================

        if (_Type_Of_Cha == Cha_Type.Like_D)
        {
            if (Cha_Happy_Bar_Float < 0.5f)
            {
                _UI_Sprite_Animation.namePrefix = "D_01_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 0.5f && Cha_Happy_Bar_Float < 1)
            {
                _UI_Sprite_Animation.namePrefix = "D_02_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 1)
            {
                _UI_Sprite_Animation.namePrefix = "D_03_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                Particle_Man_Script.Full_Level_Up_Particle[7].Play(true);

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
        }

        //=========================================================================

        if (_Type_Of_Cha == Cha_Type.Like_E)
        {
            if (Cha_Happy_Bar_Float < 0.5f)
            {
                _UI_Sprite_Animation.namePrefix = "E_01_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 0.5f && Cha_Happy_Bar_Float < 1)
            {
                _UI_Sprite_Animation.namePrefix = "E_02_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 1)
            {
                _UI_Sprite_Animation.namePrefix = "E_03_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                Particle_Man_Script.Full_Level_Up_Particle[7].Play(true);

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
        }

        //=========================================================================
        if (_Type_Of_Cha == Cha_Type.Like_G)
        {
            if (Cha_Happy_Bar_Float < 0.5f)
            {
                _UI_Sprite_Animation.namePrefix = "G_01_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 0.5f && Cha_Happy_Bar_Float < 1)
            {
                _UI_Sprite_Animation.namePrefix = "G_02_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 1)
            {
                _UI_Sprite_Animation.namePrefix = "G_03_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                Particle_Man_Script.Full_Level_Up_Particle[7].Play(true);

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
        }

        //=========================================================================

        if (_Type_Of_Cha == Cha_Type.Like_J)
        {
            if (Cha_Happy_Bar_Float < 0.5f)
            {
                _UI_Sprite_Animation.namePrefix = "J_01_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 0.5f && Cha_Happy_Bar_Float < 1)
            {
                _UI_Sprite_Animation.namePrefix = "J_02_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            if (Cha_Happy_Bar_Float >= 1)
            {
                _UI_Sprite_Animation.namePrefix = "J_03_Idle_";
                _UI_Sprite_Animation.framesPerSecond = 10;

                Particle_Man_Script.Full_Level_Up_Particle[7].Play(true);

                // 사운드 
                Sound_Man_Script.Play_Evo_Cha_08();
                Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_08();
            }

            //애니메이션 설정 
            _UI_Sprite_Animation.enabled = true;
        }

        //=========================================================================
    }

    public void Chage()
    {
        if (Cha_Stress_Bar_Float >= 1)
        {
            is_Cha_Trash();
        }
        else
        {
            is_Cha_Can_Change();
        }
    }
    //=============================================  모습 변화











    //============================================== 공동 자산 
    // 납품버튼 클릭시 + 캐릭터 냉장고로 보내는 버튼 클릭시
    public void Cha_Ani_Off()
    {
        //애니메이션 설정 
        _UI_Sprite_Animation.enabled = false;
        _UI_Sprite_Animation.namePrefix = "None";
        _UI_Sprite_Animation.framesPerSecond = 0;
    }

    // 폭발 파티클 발동
    public void Boom_Particle()
    {
        Dust.Play(true);
    }

    //앵그리 스프라이트 초기화 
    //캐릭터창 안보이게 하기
    // 해당 박스 콜라이더 정상화 
    // 해당 uisprite 정상화 
    // 수치값 초기화 // 행복도+스트레스 지수 초기화 
    public void Reset_Float()
    {
        Angry_Panel.alpha = 0f;

        Cha_UI_Panel_All_On_Off.alpha = 0f;

        Box_Change_Man_Script.Room_Reset_08();

        Cha_Happy_Bar_Float = 0f;
        Cha_Stress_Bar_Float = 0f;
        Cha_Stress_Count = 0;

        Happy_Bar_Sprite_01.fillAmount = Cha_Happy_Bar_Float;
        Stress_Bar_Sprite_01.fillAmount = Cha_Stress_Bar_Float;
    }

    public void Stop_Box_And_Reset()
    {
        Angry_Panel.alpha = 0f;

        Cha_UI_Panel_All_On_Off.alpha = 0f;

        Cha_Happy_Bar_Float = 0f;
        Cha_Stress_Bar_Float = 0f;
        Cha_Stress_Count = 0;

        Happy_Bar_Sprite_01.fillAmount = Cha_Happy_Bar_Float;
        Stress_Bar_Sprite_01.fillAmount = Cha_Stress_Bar_Float;
    }
    //============================================== 공동 자산 











    //======================================================= 코루틴
    // 격리 버튼 카운트 다운 
    public void Count_Down()
    {
        StartCoroutine("IS_Trash_Gone_Count_Down_");
    }


    // 가리기
    public void Cant_See_Grow_Button()
    {
        if (Cha_Stress_Bar_Float <= 0.99f && Con_Grow_Button == true && Cha_Happy_Bar_Float < 1)
        {
            Con_Grow_Button = false;
            StartCoroutine("Close_Grow_Button");

            Sound_Man_Script.Play_Button_Click();
        }
    }
    // 보이기
    public void Press_Cha_Open_Grow_Button()
    {
        if (Cha_Stress_Bar_Float <= 0.99f && Con_Grow_Button == false && Cha_Happy_Bar_Float < 1)
        {
            Con_Grow_Button = true;
            StartCoroutine("Open_Grow_Button");

            Sound_Man_Script.Play_Button_Click();
        }
    }

    // 쓰레기 전용 버튼 보이기 
    public void Trash_Go_Home_Button_On()
    {
        if (Con_Trash_Button == false)
        {
            Con_Trash_Button = true;
            StartCoroutine("Open_Trash_Button");
        }
    }
    // 쓰레기 전용 버튼 가리기  
    public void Trash_Go_Home_Button_Off()
    {
        if (Con_Trash_Button == true)
        {
            Con_Trash_Button = false;
            StartCoroutine("Close_Trash_Button");
        }
    }
    // 쓰레기 전용 버튼 가리기  
    public void Trash_Button_Off()
    {
        StartCoroutine("Close_Trash_Button");
    }



    // 격리 버튼 카운트 다운 
    IEnumerator IS_Trash_Gone_Count_Down_()
    {

        // 시간안에 버튼을 못눌렀으면 
        if (Trash_Go_Home_Button_Script.is_Button_Hit == false)
        {
            //0
            if (Time_Flow_Counter == 0)
            {
                // 채소 방 
                if (Type_A || Type_B || Type_C == true)
                {
                    Box_Change_Man_Script.Room_Siren_Ani_Vegetable_Room_08();
                }
                // 고기 방
                if (Type_D || Type_E == true)
                {
                    Box_Change_Man_Script.Room_Siren_Ani_Vegetable_Room_08();
                }
                // 해산물 방
                if (Type_F || Type_G || Type_H == true)
                {
                    Box_Change_Man_Script.Room_Siren_Ani_Vegetable_Room_08();
                }
                // 기타 방 
                if (Type_I || Type_J == true)
                {
                    Box_Change_Man_Script.Room_Siren_Ani_Vegetable_Room_08();
                }

                Trash_Count_Down_panel.alpha = 1f;
                //이미지 10
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_10";
            }
            //1
            if (Time_Flow_Counter == 1)
            {
                //이미지 9
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_09";
            }
            //2
            if (Time_Flow_Counter == 2)
            {
                //이미지 8
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_08";
            }
            //3
            if (Time_Flow_Counter == 3)
            {
                //이미지 7
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_07";
            }
            //4
            if (Time_Flow_Counter == 4)
            {
                //이미지 6
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_06";
            }
            //5
            if (Time_Flow_Counter == 5)
            {
                //이미지 5
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_05";
            }
            //6
            if (Time_Flow_Counter == 6)
            {
                //이미지 4
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_04";
            }
            //7
            if (Time_Flow_Counter == 7)
            {
                //이미지 3
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_03";
            }
            //8
            if (Time_Flow_Counter == 8)
            {
                //이미지 2
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_02";
            }
            //9
            if (Time_Flow_Counter == 9)
            {
                //이미지 1
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_01";
            }
            //10
            if (Time_Flow_Counter == 10)
            {
                // 초기화 
                Trash_Count_Down_panel.alpha = 0f;
                Trash_Count_Down_Sprite.spriteName = "Stage_Gag_10";
                Time_Flow_Counter = 0;
                Trash_Go_Home_Button_Script.is_Button_Hit = false;

                Con_Trash_Button = false;
               // Reset_Float();
                Cha_Ani_Off();
                Trash_Go_Home_Button_Off();
                Trash_Button_Off();

                Sound_Man_Script.Loof_Stop_Box_Cha_IS_Trash_08();

                Stop_Box_And_Reset();
                // 채소 방 
                if (Type_A || Type_B || Type_C == true)
                {
                    Box_Change_Man_Script.Room_Shelter_Vegetable_08();
                    // Box_Change_Man_Script.Stop_Room_Siren_Ani_Vegetable_Room_01();
                    //  Box_Change_Man_Script.Sprite_Reset_01();
                }
                // 고기 방
                if (Type_D || Type_E == true)
                {
                    Box_Change_Man_Script.Room_Shelter_Meat_08();
                }
                // 해산물 방
                if (Type_F || Type_G || Type_H == true)
                {
                    Box_Change_Man_Script.Room_Shelter_Ocean_08();
                }
                // 기타 방 
                if (Type_I || Type_J == true)
                {
                    Box_Change_Man_Script.Room_Shelter_Alt_08();
                }

                Fridge_Man_Script.Check_Panel_On_Off();
                Debuff.SetActive(false);

                Debug.Log("방 격리");
                yield break;
            }

        }

        // 시간안에 버튼을 눌렀으면  
        else if (Trash_Go_Home_Button_Script.is_Button_Hit == true)
        {
            // 초기화 
            Trash_Count_Down_panel.alpha = 0f;
            Trash_Count_Down_Sprite.spriteName = "Stage_Gag_10";

            Time_Flow_Counter = 0;
            Trash_Go_Home_Button_Script.is_Button_Hit = false;

            Debug.Log("격리 성공");
            ////////////////////////////////////////////////////////////////  격리 이벤트 함수 발동 
            yield break;
        }

        Debug.Log(Time_Flow_Counter);
        Time_Flow_Counter++;
        yield return new WaitForSeconds(1f);

        StartCoroutine("IS_Trash_Gone_Count_Down_");
    }


    // 쓰레기 버튼 보이게 하기 
    IEnumerator Open_Trash_Button()
    {
        if (Trash_Go_Home_Panel.alpha >= 1)
        {
            yield break;
        }
        yield return new WaitForSeconds(0.1f);

        Trash_Go_Home_Panel.alpha += 0.5f * 2;
        StartCoroutine("Open_Trash_Button");
    }
    // 쓰레기 버튼 안보이게 하기 
    IEnumerator Close_Trash_Button()
    {
        if (Trash_Go_Home_Panel.alpha <= 0)
        {
            yield break;
        }
        yield return new WaitForSeconds(0.1f);

        Trash_Go_Home_Panel.alpha -= 0.5f * 2;
        StartCoroutine("Close_Trash_Button");
    }

    //버튼이 안보이게 한다.
    IEnumerator Open_Grow_Button()
    {
        if (Press_Cha_Open_Button.alpha >= 1)
        {
            yield break;
        }
        yield return new WaitForSeconds(0.1f);

        Press_Cha_Open_Button.alpha += 0.5f * 2;
        StartCoroutine("Open_Grow_Button");
    }
    //버튼이 안보이게 한다.
    IEnumerator Close_Grow_Button()
    {
        if (Press_Cha_Open_Button.alpha <= 0)
        {
            yield break;
        }
        yield return new WaitForSeconds(0.1f);

        Press_Cha_Open_Button.alpha -= 0.5f * 2;
        StartCoroutine("Close_Grow_Button");
    }
}
