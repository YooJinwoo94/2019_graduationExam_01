using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge_Manager : MonoBehaviour {


    //캐릭터 판넬
    //================================================= 
    public UIPanel Fridge_Cha_Panel_01;
    public UIPanel Fridge_Cha_Panel_02;
    public UIPanel Fridge_Cha_Panel_03;
    public UIPanel Fridge_Cha_Panel_04;
    //================================================= 


    //냉동 게이지 판넬
    // ================================================ 
    public UIPanel Fridge_Loading_Bar_Panel_01;
    public UIPanel Fridge_Loading_Bar_Panel_02;
    public UIPanel Fridge_Loading_Bar_Panel_03;
    public UIPanel Fridge_Loading_Bar_Panel_04;
    // ================================================  


    //캐릭터 스프라이트 
    // ================================================ 
    public UISprite Fridge_Sprite_01;
    public UISprite Fridge_Sprite_02;
    public UISprite Fridge_Sprite_03;
    public UISprite Fridge_Sprite_04;
    // ================================================ 


    //애니메이션 
    // ================================================ 
    public UISpriteAnimation Fridge_Cha_Ani_01;
    public UISpriteAnimation Fridge_Cha_Ani_02;
    public UISpriteAnimation Fridge_Cha_Ani_03;
    public UISpriteAnimation Fridge_Cha_Ani_04;
    // ================================================


     bool Is_Fridge_Cha_01;
     bool Is_Fridge_Cha_02;
     bool Is_Fridge_Cha_03;
     bool Is_Fridge_Cha_04;

    public Frige_Button_Con_01 Frige_Button_Con_01_Script;
    public Frige_Button_Con_02 Frige_Button_Con_02_Script;
    public Frige_Button_Con_03 Frige_Button_Con_03_Script;
    public Frige_Button_Con_04 Frige_Button_Con_04_Script;

    public Alart_Manager Alart_Man_Script;
    public Get_Out_Trash_Cha_Manager Get_Out_Trash_Cha_Man_Script;

    string Trash_Name = "Trash_Idle_01";

    static int Escape_Time_Flow_Count_01;
    static int Escape_Time_Flow_Count_02;
    static int Escape_Time_Flow_Count_03;
    static int Escape_Time_Flow_Count_04;








    private void Awake()
    {
        Escape_Time_Flow_Count_01 = 0;
        Escape_Time_Flow_Count_02 = 0;
        Escape_Time_Flow_Count_03 = 0;
        Escape_Time_Flow_Count_04 = 0;

        Is_Fridge_Cha_01 = true;
        Is_Fridge_Cha_01 = true;
        Is_Fridge_Cha_01 = true;
        Is_Fridge_Cha_01 = true;

        Fridge_Cha_Panel_01.alpha = 0f;
        Fridge_Cha_Panel_02.alpha = 0f;
        Fridge_Cha_Panel_03.alpha = 0f;
        Fridge_Cha_Panel_04.alpha = 0f;


        Fridge_Loading_Bar_Panel_01.alpha = 0f;
        Fridge_Loading_Bar_Panel_02.alpha = 0f;
        Fridge_Loading_Bar_Panel_03.alpha = 0f;
        Fridge_Loading_Bar_Panel_04.alpha = 0f;



        // ================================================ 애니메이션 

        Fridge_Sprite_01.spriteName = "None";
        Fridge_Sprite_02.spriteName = "None";
        Fridge_Sprite_03.spriteName = "None";
        Fridge_Sprite_04.spriteName = "None";

        Fridge_Cha_Ani_01.enabled = false;
        Fridge_Cha_Ani_02.enabled = false;
        Fridge_Cha_Ani_03.enabled = false;
        Fridge_Cha_Ani_04.enabled = false;

        Fridge_Cha_Ani_01.namePrefix = "None";
        Fridge_Cha_Ani_02.namePrefix = "None";
        Fridge_Cha_Ani_03.namePrefix = "None";
        Fridge_Cha_Ani_04.namePrefix = "None";

        Fridge_Cha_Ani_01.framesPerSecond = 0;
        Fridge_Cha_Ani_02.framesPerSecond = 0;
        Fridge_Cha_Ani_03.framesPerSecond = 0;
        Fridge_Cha_Ani_04.framesPerSecond = 0;

        // ================================================ 애니메이션 
    }











    // 냉장고에 애들 넣기 
    public void Check_Panel_On_Off()
    {
        if (Is_Fridge_Cha_01 == true)
        {
            // 여기가 비어있으니 여기에 생성하겠습니다.       =>>>   현재칸에 생성
            if (Fridge_Sprite_01.spriteName == "None")
            {
                // 생성 
                Fridge_Cha_Panel_01.alpha = 1f;

                //이미지 변화
                Fridge_Sprite_01.spriteName = Trash_Name;

                Time_Count_For_Escape_01();

                // 애니메이션
                Normal_Ani_01();
            }

            // 중복이 아닌경우 + 빈칸이 아닌 경우            =>>> 다른 칸으로 가세요 
            else if (Fridge_Sprite_01.spriteName != "None")
            {
                Is_Fridge_Cha_01 = false;
                Is_Fridge_Cha_02 = true;
            }
        }
        // 2번 검사하기
        if (Is_Fridge_Cha_01 == false)
        {
            if (Is_Fridge_Cha_02 == true)
            {
                // 여기가 비어있으니 여기에 생성하겠습니다.       =>>>   현재칸에 생성
                if (Fridge_Sprite_02.spriteName == "None")
                {
                    // 생성 
                    Fridge_Cha_Panel_02.alpha = 1f;

                    //이미지 변화
                    Fridge_Sprite_02.spriteName = Trash_Name;

                    Time_Count_For_Escape_02();

                    // 애니메이션
                    Normal_Ani_02();
                }

                // 중복이 아닌경우 + 빈칸이 아닌 경우            =>>> 다른 칸으로 가세요 
                else if (Fridge_Sprite_02.spriteName != "None")
                {
                    Is_Fridge_Cha_02 = false;
                    Is_Fridge_Cha_03 = true;
                }
            }
        }
        // 3번 검사하기
        if (Is_Fridge_Cha_02 == false)
        {
            if (Is_Fridge_Cha_03 == true)
            {
                // 여기가 비어있으니 여기에 생성하겠습니다.       =>>>   현재칸에 생성
                if (Fridge_Sprite_03.spriteName == "None")
                {
                    // 생성 
                    Fridge_Cha_Panel_03.alpha = 1f;

                    //이미지 변화
                    Fridge_Sprite_03.spriteName = Trash_Name;

                    Time_Count_For_Escape_03();

                    // 애니메이션
                    Normal_Ani_03();
                }

                // 중복이 아닌경우 + 빈칸이 아닌 경우            =>>> 다른 칸으로 가세요 
                else if (Fridge_Sprite_03.spriteName != "None")
                {
                    Is_Fridge_Cha_03 = false;
                    Is_Fridge_Cha_04 = true;
                }
            }
        }
        // 4번 검사하기 + 끝 
        if (Is_Fridge_Cha_03 == false)
        {
            if (Is_Fridge_Cha_04 == true)
            {
                // 여기가 비어있으니 여기에 생성하겠습니다.       =>>>   현재칸에 생성
                if (Fridge_Sprite_04.spriteName == "None")
                {
                    // 생성 
                    Fridge_Cha_Panel_04.alpha = 1f;

                    //이미지 변화
                    Fridge_Sprite_04.spriteName = Trash_Name;

                    Time_Count_For_Escape_04();

                    // 애니메이션
                    Normal_Ani_04();
                }

                // 중복이 아닌경우 + 빈칸이 아닌 경우            +    끝
                else if (Fridge_Sprite_04.spriteName != "None")
                {
                    Debug.Log("끝");
                }
            }
        }
        // Reset_Bool
        Is_Fridge_Cha_01 = true;
        Is_Fridge_Cha_02 = false;
        Is_Fridge_Cha_03 = false;
        Is_Fridge_Cha_04 = false;
    }





    public void Normal_Ani_01()
    {
        // 애니메이션
       

        Fridge_Cha_Ani_01.loop = true;
        Fridge_Cha_Ani_01.namePrefix = "Trash_Idle_";
        Fridge_Cha_Ani_01.framesPerSecond = 10;
        Fridge_Cha_Ani_01.enabled = true;
        Fridge_Cha_Ani_01.Play();

    }
    public void Normal_Ani_02()
    {
        // 애니메이션
        Fridge_Cha_Ani_02.loop = true;
        Fridge_Cha_Ani_02.namePrefix = "Trash_Idle_";
        Fridge_Cha_Ani_02.framesPerSecond = 10;
        Fridge_Cha_Ani_02.enabled = true;
        Fridge_Cha_Ani_02.Play();
    }
    public void Normal_Ani_03()
    {
        // 애니메이션
        Fridge_Cha_Ani_03.namePrefix = "Trash_Idle_";
        Fridge_Cha_Ani_03.framesPerSecond = 10;
        Fridge_Cha_Ani_03.loop = true;
        Fridge_Cha_Ani_03.enabled = true;
        Fridge_Cha_Ani_03.Play();
    }
    public void Normal_Ani_04()
    {
        // 애니메이션
        Fridge_Cha_Ani_04.namePrefix = "Trash_Idle_";
        Fridge_Cha_Ani_04.framesPerSecond = 10;
        Fridge_Cha_Ani_04.loop = true;
        Fridge_Cha_Ani_04.enabled = true;
        Fridge_Cha_Ani_04.Play();
    }

    public void Freeze_Ani_01()
    {
        // 애니메이션
            Fridge_Cha_Ani_01.namePrefix = "Trash_Cha_Freeze_";
            Fridge_Cha_Ani_01.framesPerSecond = 10;
            Fridge_Cha_Ani_01.loop = false;
            Fridge_Cha_Ani_01.enabled = true;
            Fridge_Cha_Ani_01.Play();
    }
    public void Freeze_Ani_02()
    {
        // 애니메이션

        Fridge_Cha_Ani_02.namePrefix = "Trash_Cha_Freeze_";
        Fridge_Cha_Ani_02.framesPerSecond = 10;
        Fridge_Cha_Ani_02.loop = false;
        Fridge_Cha_Ani_02.enabled = true;
        Fridge_Cha_Ani_02.Play();
    }
    public void Freeze_Ani_03()
    {
        // 애니메이션

        Fridge_Cha_Ani_03.namePrefix = "Trash_Cha_Freeze_";
        Fridge_Cha_Ani_03.framesPerSecond = 10;
        Fridge_Cha_Ani_03.loop = false;
        Fridge_Cha_Ani_03.enabled = true;
        Fridge_Cha_Ani_03.Play();
    }
    public void Freeze_Ani_04()
    {
        // 애니메이션

        Fridge_Cha_Ani_04.namePrefix = "Trash_Cha_Freeze_";
        Fridge_Cha_Ani_04.framesPerSecond = 10;
        Fridge_Cha_Ani_04.loop = false;
        Fridge_Cha_Ani_04.enabled = true;
        Fridge_Cha_Ani_04.Play();
    }

    public void Ani_Enabled_False_01()
    {
        // 애니메이션
        Fridge_Cha_Ani_01.enabled = false;
        Fridge_Cha_Ani_01.namePrefix = "";
        Fridge_Cha_Ani_01.framesPerSecond = 10;
        Fridge_Cha_Ani_01.loop = true;
    }
    public void Ani_Enabled_False_02()
    {
        // 애니메이션
        Fridge_Cha_Ani_02.enabled = false;
        Fridge_Cha_Ani_02.namePrefix = "";
        Fridge_Cha_Ani_02.framesPerSecond = 10;
        Fridge_Cha_Ani_02.loop = true;
    }
    public void Ani_Enabled_False_03()
    {
        // 애니메이션
        Fridge_Cha_Ani_03.enabled = false;
        Fridge_Cha_Ani_03.namePrefix = "";
        Fridge_Cha_Ani_03.framesPerSecond = 10;
        Fridge_Cha_Ani_03.loop = true;
    }
    public void Ani_Enabled_False_04()
    {
        // 애니메이션
        Fridge_Cha_Ani_04.enabled = false;
        Fridge_Cha_Ani_04.namePrefix = "";
        Fridge_Cha_Ani_04.framesPerSecond = 10;
        Fridge_Cha_Ani_04.loop = true;
    }







    //  발동하는 카운트 다운 

    public void Time_Count_For_Escape_01()
    {
        StartCoroutine("Time_Count_For_Escape_Time_01");
    }
    public void Time_Count_For_Escape_02()
    {
        StartCoroutine("Time_Count_For_Escape_Time_02");
    }
    public void Time_Count_For_Escape_03()
    {
        StartCoroutine("Time_Count_For_Escape_Time_03");
    }
    public void Time_Count_For_Escape_04()
    {
        StartCoroutine("Time_Count_For_Escape_Time_04");
    }

    //  발동하는 카운트 다운 




    // 다음 냉동을 기다리는 아이의 카운트 다운 

    IEnumerator Time_Count_For_Escape_Time_01()
    {
        Debug.Log("a");
        if (Frige_Button_Con_01_Script.IS_Button_Click == true)
        {
            Debug.Log("aasaaa");
            Escape_Time_Flow_Count_01 = 0;
            Frige_Button_Con_04_Script.IS_Button_Click = false;
            yield break;
        }

        else if (Escape_Time_Flow_Count_01 == 15)
        {
            Debug.Log("aasa");
            
            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]가 도망쳤습니다.");
            Frige_Button_Con_01_Script.Reset_Panel_Sprite_01();

            Get_Out_Trash_Cha_Man_Script.Is_Trash_Cha_Here();

         

            Escape_Time_Flow_Count_01 = 0;
            yield break;
        }

        else if (Escape_Time_Flow_Count_01 == 7)
        {
            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]를 얼려주세요");          
        }

        Escape_Time_Flow_Count_01++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_For_Escape_Time_01");
    }
    IEnumerator Time_Count_For_Escape_Time_02()
    {
        if (Frige_Button_Con_02_Script.IS_Button_Click == true)
        {
            Debug.Log("aasaaa");
            Escape_Time_Flow_Count_02 = 0;
            Frige_Button_Con_04_Script.IS_Button_Click = false;
            yield break;
        }

        else if (Escape_Time_Flow_Count_02 == 15)
        {
            Debug.Log("aasa");

            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]가 도망쳤습니다.");
            Frige_Button_Con_02_Script.Reset_Panel_Sprite();

            Get_Out_Trash_Cha_Man_Script.Is_Trash_Cha_Here();

          

            Escape_Time_Flow_Count_02 = 0;
            yield break;
        }

        else if (Escape_Time_Flow_Count_02 == 7)
        {
            Debug.Log("aaa");

            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]를 얼려주세요");
        }

        Escape_Time_Flow_Count_02++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_For_Escape_Time_02");
    }
    IEnumerator Time_Count_For_Escape_Time_03()
    {
       if (Frige_Button_Con_03_Script.IS_Button_Click == true)
        {
            Debug.Log("aasaaa");
            Escape_Time_Flow_Count_03 = 0;
            Frige_Button_Con_04_Script.IS_Button_Click = false;
            yield break;
        }

        else if (Escape_Time_Flow_Count_03 == 15)
        {
            Debug.Log("aasa");

            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]가 도망쳤습니다.");
            Frige_Button_Con_03_Script.Reset_Panel_Sprite();

            Get_Out_Trash_Cha_Man_Script.Is_Trash_Cha_Here();


            Escape_Time_Flow_Count_03 = 0;
            yield break;
        }

        else if (Escape_Time_Flow_Count_03 == 7)
        {
            Debug.Log("aaa");

            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]를 얼려주세요");
        }


        Escape_Time_Flow_Count_03++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_For_Escape_Time_03");
    }
    IEnumerator Time_Count_For_Escape_Time_04()
    {
       if (Frige_Button_Con_04_Script.IS_Button_Click == true)
        {
            Debug.Log("aasaaa");
            Escape_Time_Flow_Count_04 = 0;

            Frige_Button_Con_04_Script.IS_Button_Click = false;
            yield break;
        }

        else if (Escape_Time_Flow_Count_04 == 15)
        {
            Debug.Log("aasa");

            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]가 도망쳤습니다.");
            Frige_Button_Con_04_Script.Reset_Panel_Sprite();

            Get_Out_Trash_Cha_Man_Script.Is_Trash_Cha_Here();

  

            Escape_Time_Flow_Count_04 = 0;
            yield break;
        }

        else if (Escape_Time_Flow_Count_04 == 7)
        {
            Debug.Log("aaa");

            Alart_Man_Script.Set_Alart("[8ACE19]쓰레기[-]를 얼려주세요");
        }

        Escape_Time_Flow_Count_04++;

        yield return new WaitForSeconds(1f);
        StartCoroutine("Time_Count_For_Escape_Time_04");
    }

    // 다음 냉동을 기다리는 아이의 카운트 다운 










    public void Fridge_Loading_Bar_01_On()
    {
        Fridge_Loading_Bar_Panel_01.alpha = 1f;
  
    }
    public void Fridge_Loading_Bar_01_Off()
    {
        Fridge_Loading_Bar_Panel_01.alpha = 0f;
    }
//=====================================================

    public void Fridge_Loading_Bar_02_On()
    {
        Fridge_Loading_Bar_Panel_02.alpha = 1f;
  
    }
    public void Fridge_Loading_Bar_02_Off()
    {
        Fridge_Loading_Bar_Panel_02.alpha = 0f;
    }
//=====================================================

    public void Fridge_Loading_Bar_03_On()
    {
        Fridge_Loading_Bar_Panel_03.alpha = 1f;

    }
    public void Fridge_Loading_Bar_03_Off()
    {
        Fridge_Loading_Bar_Panel_03.alpha = 0f;
    }
//=====================================================

    public void Fridge_Loading_Bar_04_On()
    {
        Fridge_Loading_Bar_Panel_04.alpha = 1f;
  
    }
    public void Fridge_Loading_Bar_04_Off()
    {
        Fridge_Loading_Bar_Panel_04.alpha = 0f;
    }
}
