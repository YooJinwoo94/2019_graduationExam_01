using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Script : MonoBehaviour {

    public  int Shop_Item_Count = 0;

    public UIPanel Shop_Panel_01;
    public UIPanel Shop_Panel_02;
    public UIPanel Shop_Panel_03;
    public UIPanel Shop_Panel_04;
    public UIPanel Shop_Panel_05;
    public UIPanel Shop_Panel_06;

    public UIPanel Shop_Panel_07;
    public UIPanel Shop_Panel_08;
    public UIPanel Shop_Panel_09;
    public UIPanel Shop_Panel_10;
    public UIPanel Shop_Panel_11;
    public UIPanel Shop_Panel_12;


    public bool IS_Shop_Open;
    public bool IS_Shop_Close;

    public Transform[] Item_Positon;

    public Main_Cam _Main_Cam_Script;

    public UIPanel Shop_UI_Scroll_View_Panel;

    public bool is_Player_Press_Button_01;
    public bool is_Player_Press_Button_02;
    public bool is_Player_Press_Button_03;
    public bool is_Player_Press_Button_04;
    public bool is_Player_Press_Button_05;
    public bool is_Player_Press_Button_06;
    public bool is_Player_Press_Button_07;
    public bool is_Player_Press_Button_08;
    public bool is_Player_Press_Button_09;
    public bool is_Player_Press_Button_10;
    public bool is_Player_Press_Button_11;
    public bool is_Player_Press_Button_12;

    public Box_Ani_Start_Or_Stop Box_Ani_Start_Or_Stop_Script;
    public Sound_Manager Sound_Man_Script;


    public UISlider[] Reset_Shop_Panel_Pos;


    private void Start()
    {
        IS_Shop_Open = false;
    }






    public void Shop_UI_Panel_Open_01()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_01 = true;
            
            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_01");
            
            // 중복 불가 데스 
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_01_On();
            Sound_Man_Script.Play_Room_Click();
        }       
    }
    public void Shop_UI_Panel_Close_01()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[0].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_01 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_01");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_01_Off();
            Sound_Man_Script.Play_Button_Click();
        }

    }

    public void Shop_UI_Panel_Open_02()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_02 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_02");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_02_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_02()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[1].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_02 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_02");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_02_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_03()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_03 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_03");

            // 중복 불가 데스 
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_03_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_03()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[2].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_03 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_03");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_03_Off();
            Sound_Man_Script.Play_Button_Click();
        }

    }

    public void Shop_UI_Panel_Open_04()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_04 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_04");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_04_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_04()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[3].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_04 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_04");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_04_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_05()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_05 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_05");

            // 중복 불가 데스 
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_05_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_05()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[4].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_05 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_05");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_05_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_06()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_06 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_06");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_06_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_06()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[5].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_06 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_06");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_06_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_07()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_07 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_07");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_07_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_07()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[6].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_07 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_07");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_07_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_08()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_08 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_08");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_08_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_08()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[7].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_08 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_08");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_08_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_09()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_09 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_09");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_09_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_09()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[8].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_09 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_09");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_09_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_10()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_10 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_10");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_10_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_10()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[9].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_10 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_10");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_10_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_11()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_11 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_11");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_11_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_11()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[10].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_11 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_11");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_11_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }

    public void Shop_UI_Panel_Open_12()
    {
        if (IS_Shop_Open == false)
        {
            // 화면 전환 안되게 하기
            _Main_Cam_Script.Is_Cam_Stop = true;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_12 = true;

            // 유아이창 뜨기 
            StartCoroutine("Ui_Open_12");

            // 중복 불가 데스
            IS_Shop_Open = true;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_12_On();
            Sound_Man_Script.Play_Room_Click();
        }
    }
    public void Shop_UI_Panel_Close_12()
    {
        if (IS_Shop_Open == true)
        {
            Reset_Shop_Panel_Pos[11].value = 0.15f;

            // 화면 전환 하게 만들기
            _Main_Cam_Script.Is_Cam_Stop = false;

            // 해당 위치에 캐릭터 생성하기 위한 bool 값 
            is_Player_Press_Button_12 = false;

            // 유아이창 끄기
            StartCoroutine("Ui_Close_12");

            // 중복 불가 데스
            IS_Shop_Open = false;

            Box_Ani_Start_Or_Stop_Script.SpriteAni_12_Off();
            Sound_Man_Script.Play_Button_Click();
        }
    }




    IEnumerator Ui_Open_01()
    {
        if (Shop_Panel_01.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_01.alpha += 1f;

        StartCoroutine("Ui_Open_01");
    }
    IEnumerator Ui_Close_01()
    {
        if (Shop_Panel_01.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_01.alpha -= 1f;

        StartCoroutine("Ui_Close_01");
    }

    IEnumerator Ui_Open_02()
    {
        if (Shop_Panel_02.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_02.alpha += 1f;

        StartCoroutine("Ui_Open_02");
    }
    IEnumerator Ui_Close_02()
    {
        if (Shop_Panel_02.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_02.alpha -= 1f;

        StartCoroutine("Ui_Close_02");
    }

    IEnumerator Ui_Open_03()
    {
        if (Shop_Panel_03.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_03.alpha += 1f;

        StartCoroutine("Ui_Open_03");
    }
    IEnumerator Ui_Close_03()
    {
        if (Shop_Panel_03.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_03.alpha -= 1f;

        StartCoroutine("Ui_Close_03");
    }

    IEnumerator Ui_Open_04()
    {
        if (Shop_Panel_04.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_04.alpha += 1f;

        StartCoroutine("Ui_Open_04");
    }
    IEnumerator Ui_Close_04()
    {
        if (Shop_Panel_04.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_04.alpha -= 1f;

        StartCoroutine("Ui_Close_04");
    }

    IEnumerator Ui_Open_05()
    {
        if (Shop_Panel_05.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_05.alpha += 1f;

        StartCoroutine("Ui_Open_05");
    }
    IEnumerator Ui_Close_05()
    {
        if (Shop_Panel_05.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_05.alpha -= 1f;

        StartCoroutine("Ui_Close_05");
    }

    IEnumerator Ui_Open_06()
    {
        if (Shop_Panel_06.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_06.alpha += 1f;

        StartCoroutine("Ui_Open_06");
    }
    IEnumerator Ui_Close_06()
    {
        if (Shop_Panel_06.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_06.alpha -= 1f;

        StartCoroutine("Ui_Close_06");
    }

    IEnumerator Ui_Open_07()
    {
        if (Shop_Panel_07.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_07.alpha += 1f;

        StartCoroutine("Ui_Open_07");
    }
    IEnumerator Ui_Close_07()
    {
        if (Shop_Panel_07.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_07.alpha -= 1f;

        StartCoroutine("Ui_Close_07");
    }

    IEnumerator Ui_Open_08()
    {
        if (Shop_Panel_08.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_08.alpha += 1f;

        StartCoroutine("Ui_Open_08");
    }
    IEnumerator Ui_Close_08()
    {
        if (Shop_Panel_08.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_08.alpha -= 1f;

        StartCoroutine("Ui_Close_08");
    }

    IEnumerator Ui_Open_09()
    {
        if (Shop_Panel_09.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_09.alpha += 1f;

        StartCoroutine("Ui_Open_09");
    }
    IEnumerator Ui_Close_09()
    {
        if (Shop_Panel_09.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_09.alpha -= 1f;

        StartCoroutine("Ui_Close_09");
    }

    IEnumerator Ui_Open_10()
    {
        if (Shop_Panel_10.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_10.alpha += 1f;

        StartCoroutine("Ui_Open_10");
    }
    IEnumerator Ui_Close_10()
    {
        if (Shop_Panel_10.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_10.alpha -= 1f;

        StartCoroutine("Ui_Close_10");
    }

    IEnumerator Ui_Open_11()
    {
        if (Shop_Panel_11.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_11.alpha += 1f;

        StartCoroutine("Ui_Open_11");
    }
    IEnumerator Ui_Close_11()
    {
        if (Shop_Panel_11.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_11.alpha -= 1f;

        StartCoroutine("Ui_Close_11");
    }

    IEnumerator Ui_Open_12()
    {
        if (Shop_Panel_12.alpha == 1)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_12.alpha += 1f;

        StartCoroutine("Ui_Open_12");
    }
    IEnumerator Ui_Close_12()
    {
        if (Shop_Panel_12.alpha == 0)
        {
            yield break;
        }

        yield return new WaitForSeconds(0.1f);
        Shop_Panel_12.alpha -= 1f;

        StartCoroutine("Ui_Close_12");
    }
}
