using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order_Food_Manager : MonoBehaviour {

    public bool Is_Order_01 = true;
    public bool Is_Order_02 = false;
    public bool Is_Order_03 = false;
    public bool Is_Order_04 = false;

    public Alart_Manager _Alart_Manager_Script;

    public Main_Cam _Main_Cam_Script;

    public Food_Order_Controller_01 _Food_Con_Script_01;
    public Food_Order_Controller_02 _Food_Con_Script_02;
    public Food_Order_Controller_03 _Food_Con_Script_03;
    public Food_Order_Controller_04 _Food_Con_Script_04;

    public Open_Detail_Order Detail_Order_Food_Script;

    public UISprite[] X_Sprite;

    // 주문 시간 
    private float Phase_Of_Order_01_A;
    private float Phase_Of_Order_01_B;
    private float Phase_Of_Order_01_C;
    private float Phase_Of_Order_01_D;
    private float Phase_Of_Order_01_E;
    private float Phase_Of_Order_01_F;
    private float Phase_Of_Order_01_G;
    private float Phase_Of_Order_01_H;
    private float Phase_Of_Order_01_I;

    private float Phase_Of_Order_02_A;
    private float Phase_Of_Order_02_B;
    private float Phase_Of_Order_02_C;
    private float Phase_Of_Order_02_D;
    private float Phase_Of_Order_02_E;
    private float Phase_Of_Order_02_F;
    private float Phase_Of_Order_02_G;
    private float Phase_Of_Order_02_H;
    private float Phase_Of_Order_02_I;

    private float Phase_Of_Order_03_A;
    private float Phase_Of_Order_03_B;
    private float Phase_Of_Order_03_C;
    private float Phase_Of_Order_03_D;
    private float Phase_Of_Order_03_E;
    private float Phase_Of_Order_03_F;
    private float Phase_Of_Order_03_G;
    private float Phase_Of_Order_03_H;
    private float Phase_Of_Order_03_I;

    private float Phase_Of_Order_04_A;
    private float Phase_Of_Order_04_B;
    private float Phase_Of_Order_04_C;
    private float Phase_Of_Order_04_D;
    private float Phase_Of_Order_04_E;
    private float Phase_Of_Order_04_F;
    private float Phase_Of_Order_04_G;
    private float Phase_Of_Order_04_H;
    private float Phase_Of_Order_04_I;

    // 나누기 해서 1로  치환할 값 
    private float Phase_Of_Order_A_To_1;
    private float Phase_Of_Order_B_To_1;
    private float Phase_Of_Order_C_To_1;
    private float Phase_Of_Order_D_To_1;
    private float Phase_Of_Order_E_To_1;
    private float Phase_Of_Order_F_To_1;
    private float Phase_Of_Order_G_To_1;
    private float Phase_Of_Order_H_To_1;
    private float Phase_Of_Order_I_To_1;

    private float Phase_Of_Order_A_To_2;
    private float Phase_Of_Order_B_To_2;
    private float Phase_Of_Order_C_To_2;
    private float Phase_Of_Order_D_To_2;
    private float Phase_Of_Order_E_To_2;
    private float Phase_Of_Order_F_To_2;
    private float Phase_Of_Order_G_To_2;
    private float Phase_Of_Order_H_To_2;
    private float Phase_Of_Order_I_To_2;

    private float Phase_Of_Order_A_To_3;
    private float Phase_Of_Order_B_To_3;
    private float Phase_Of_Order_C_To_3;
    private float Phase_Of_Order_D_To_3;
    private float Phase_Of_Order_E_To_3;
    private float Phase_Of_Order_F_To_3;
    private float Phase_Of_Order_G_To_3;
    private float Phase_Of_Order_H_To_3;
    private float Phase_Of_Order_I_To_3;

    private float Phase_Of_Order_A_To_4;
    private float Phase_Of_Order_B_To_4;
    private float Phase_Of_Order_C_To_4;
    private float Phase_Of_Order_D_To_4;
    private float Phase_Of_Order_E_To_4;
    private float Phase_Of_Order_F_To_4;
    private float Phase_Of_Order_G_To_4;
    private float Phase_Of_Order_H_To_4;
    private float Phase_Of_Order_I_To_4;

    // 주문서 창 판넬
    public UIPanel Order_01_Panel;
    public UIPanel Order_02_Panel;
    public UIPanel Order_03_Panel;
    public UIPanel Order_04_Panel;

    public Transform Order_UI;


    public UIButton Open_Close_Order_Ui_Button;

    // 주문서의 타임바 
    public UISprite Time_Bar_01;
    public UISprite Time_Bar_02;
    public UISprite Time_Bar_03;
    public UISprite Time_Bar_04;

    public UISprite Detail_UI_Time_Bar_01;
    public UISprite Detail_UI_Time_Bar_02;
    public UISprite Detail_UI_Time_Bar_03;
    public UISprite Detail_UI_Time_Bar_04;


    public bool Payed_01 = false;
    public bool Payed_02 = false;
    public bool Payed_03 = false;
    public bool Payed_04 = false;






    // 리미트 시간 설정
    private void Awake()
    {
        // 각 요리의 리미트 시간 설정
        Phase_Of_Order_01_A = 80f;
        Phase_Of_Order_01_B = 80f;
        Phase_Of_Order_01_C = 80f;
        Phase_Of_Order_01_D = 80f;
        Phase_Of_Order_01_E = 80f;
        Phase_Of_Order_01_F = 80f;
        Phase_Of_Order_01_G = 80f;
        Phase_Of_Order_01_H = 80f;
        Phase_Of_Order_01_I = 80f;

        Phase_Of_Order_02_A = 80f;
        Phase_Of_Order_02_B = 80f;
        Phase_Of_Order_02_C = 80f;
        Phase_Of_Order_02_D = 80f;
        Phase_Of_Order_02_E = 80f;
        Phase_Of_Order_02_F = 80f;
        Phase_Of_Order_02_G = 80f;
        Phase_Of_Order_02_H = 80f;
        Phase_Of_Order_02_I = 80f;

        Phase_Of_Order_03_A = 80f;
        Phase_Of_Order_03_B = 80f;
        Phase_Of_Order_03_C = 80f;
        Phase_Of_Order_03_D = 80f;
        Phase_Of_Order_03_E = 80f;
        Phase_Of_Order_03_F = 80f;
        Phase_Of_Order_03_G = 80f;
        Phase_Of_Order_03_H = 80f;
        Phase_Of_Order_03_I = 80f;

        Phase_Of_Order_04_A = 80f;
        Phase_Of_Order_04_B = 80f;
        Phase_Of_Order_04_C = 80f;
        Phase_Of_Order_04_D = 80f;
        Phase_Of_Order_04_E = 80f;
        Phase_Of_Order_04_F = 80f;
        Phase_Of_Order_04_G = 80f;
        Phase_Of_Order_04_H = 80f;
        Phase_Of_Order_04_I = 80f;
    }






    // 요리의 레시피를 적어봅니다.
    //1번 퀘스트 창
    public void Pop_Up_UI_01_A()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_1";
        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "A_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "None";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_1";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "None";
     
        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "None";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "";

        Time_On_01_A();
    }
    public void Pop_Up_UI_01_B()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_2";
        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "B_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "None";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_2";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "B_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "None";

        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "None";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "";

        Time_On_01_B();
    }
    public void Pop_Up_UI_01_C()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_3";

        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "A_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "B_03_Idle_01";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "1";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_3";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "B_03_Idle_01";

        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "Detail_Order_x";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "1";

        Time_On_01_C();
    }
    public void Pop_Up_UI_01_D()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_4";

        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "D_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "None";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_4";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "D_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "None";

        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "None";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "";

        Time_On_01_D();
    }
    public void Pop_Up_UI_01_E()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_5";

        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "E_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "None";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_5";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "E_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "None";

        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "None";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "";

        Time_On_01_E();
    }
    public void Pop_Up_UI_01_F()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_6";
        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "G_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "None";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_6";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "G_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "None";

        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "None";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "";

        Time_On_01_F();
    }
    public void Pop_Up_UI_01_G()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_7";

        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "J_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "None";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_7";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "J_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "None";

        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "None";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "";

        Time_On_01_G();
    }
    public void Pop_Up_UI_01_H()
    {
        Order_01_Panel.alpha = 1f;

        _Food_Con_Script_01._Food_Sprite_01.spriteName = "A_8";

        _Food_Con_Script_01._Need_Sprite_01_01.spriteName = "C_03_Idle_01";
        _Food_Con_Script_01._Need_Sprite_02_01.spriteName = "None";

        _Food_Con_Script_01._Need_Label_01_01.text = "1";
        _Food_Con_Script_01._Need_Label_02_01.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_01_01.spriteName = "A_8";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_01.spriteName = "C_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_01_02.spriteName = "None";

        X_Sprite[0].spriteName = "Detail_Order_x";
        X_Sprite[1].spriteName = "None";
        X_Sprite[2].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_01_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_01_02.text = "";

        Time_On_01_H();
    }



    //================================================================================================================================================================
    //2번 퀘스트 창
    public void Pop_Up_UI_02_A()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_1";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "A_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "None";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_1";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "None";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "None";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "";

        Time_On_02_A();
    }
    public void Pop_Up_UI_02_B()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_2";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "B_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "None";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_2";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "B_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "None";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "None";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "";

        Time_On_02_B();
    }
    public void Pop_Up_UI_02_C()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_3";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "A_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "B_03_Idle_01";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "1";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_3";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "B_03_Idle_01";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "Detail_Order_x";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "1";

        Time_On_02_C();
    }
    public void Pop_Up_UI_02_D()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_4";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "D_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "None";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_4";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "D_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "None";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "None";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "";

        Time_On_02_D();
    }
    public void Pop_Up_UI_02_E()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_5";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "E_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "None";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_5";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "E_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "None";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "None";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "";

        Time_On_02_E();
    }
    public void Pop_Up_UI_02_F()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_6";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "G_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "None";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_6";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "G_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "None";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "None";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "";

        Time_On_02_F();
    }
    public void Pop_Up_UI_02_G()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_7";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "J_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "None";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_7";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "J_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "None";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "None";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "";

        Time_On_02_G();
    }
    public void Pop_Up_UI_02_H()
    {
        Order_02_Panel.alpha = 1f;

        _Food_Con_Script_02._Food_Sprite_02.spriteName = "A_8";

        _Food_Con_Script_02._Need_Sprite_01_02.spriteName = "C_03_Idle_01";
        _Food_Con_Script_02._Need_Sprite_02_02.spriteName = "None";

        _Food_Con_Script_02._Need_Label_01_02.text = "1";
        _Food_Con_Script_02._Need_Label_02_02.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_02_01.spriteName = "A_8";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_01.spriteName = "C_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_02_02.spriteName = "None";

        X_Sprite[3].spriteName = "Detail_Order_x";
        X_Sprite[4].spriteName = "None";
        X_Sprite[5].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_02_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_02_02.text = "";

        Time_On_02_H();
    }




    //================================================================================================================================================================
    //3번 퀘스트 창
    public void Pop_Up_UI_03_A()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_1";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "A_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "None";

        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_1";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "None";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "None";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "";

        Time_On_03_A();
    }
    public void Pop_Up_UI_03_B()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_2";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "B_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "None";

        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_2";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "B_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "None";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "None";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "";

        Time_On_03_B();
    }
    public void Pop_Up_UI_03_C()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_3";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "A_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "B_03_Idle_01";

        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "1";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_3";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "B_03_Idle_01";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "Detail_Order_x";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "1";

        Time_On_03_C();
    }
    public void Pop_Up_UI_03_D()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_4";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "D_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "None";

        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_4";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "D_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "None";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "None";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "";

        Time_On_03_D();
    }
    public void Pop_Up_UI_03_E()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_5";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "E_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "None";

        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_5";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "E_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "None";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "None";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "";

        Time_On_03_E();
    }
    public void Pop_Up_UI_03_F()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_6";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "G_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "None";

        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_6";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "G_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "None";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "None";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "";

        Time_On_03_F();
    }
    public void Pop_Up_UI_03_G()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_7";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "J_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "None";

        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_7";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "J_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "None";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "None";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "";

        Time_On_03_G();
    }
    public void Pop_Up_UI_03_H()
    {
        Order_03_Panel.alpha = 1f;

        _Food_Con_Script_03._Food_Sprite_03.spriteName = "A_8";

        _Food_Con_Script_03._Need_Sprite_01_03.spriteName = "C_03_Idle_01";
        _Food_Con_Script_03._Need_Sprite_02_03.spriteName = "None";


        _Food_Con_Script_03._Need_Label_01_03.text = "1";
        _Food_Con_Script_03._Need_Label_02_03.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테
        ///일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_03_01.spriteName = "A_8";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_01.spriteName = "C_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_03_02.spriteName = "None";

        X_Sprite[6].spriteName = "Detail_Order_x";
        X_Sprite[7].spriteName = "None";
        X_Sprite[8].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_03_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_03_02.text = "";

        Time_On_03_H();
    }
 




    //4번 퀘스트 창
    public void Pop_Up_UI_04_A()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_1";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "A_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "None";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_1";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "None";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "None";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = ""; 

        Time_On_04_A();
    }
    public void Pop_Up_UI_04_B()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_2";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "B_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "None";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_2";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "B_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "None";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "None";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = "";

        Time_On_04_B();
    }
    public void Pop_Up_UI_04_C()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_3";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "A_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "B_03_Idle_01";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "1";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_3";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "A_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "B_03_Idle_01";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "Detail_Order_x";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = "1";

        Time_On_04_C();
    }
    public void Pop_Up_UI_04_D()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_4";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "D_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "None";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_4";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "D_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "None";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "None";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = "";

        Time_On_04_D();
    }
    public void Pop_Up_UI_04_E()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_5";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "E_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "None";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_5";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "E_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "None";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "None";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = "";

        Time_On_04_E();
    }
    public void Pop_Up_UI_04_F()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_6";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "G_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "None";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_6";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "G_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "None";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "None";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = "";

        Time_On_04_F();
    }
    public void Pop_Up_UI_04_G()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_7";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "J_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "None";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_7";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "J_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "None";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "None";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = "";

        Time_On_04_G();
    }
    public void Pop_Up_UI_04_H()
    {
        Order_04_Panel.alpha = 1f;

        _Food_Con_Script_04._Food_Sprite_04.spriteName = "A_8";

        _Food_Con_Script_04._Need_Sprite_01_04.spriteName = "C_03_Idle_01";
        _Food_Con_Script_04._Need_Sprite_02_04.spriteName = "None";

        _Food_Con_Script_04._Need_Label_01_04.text = "1";
        _Food_Con_Script_04._Need_Label_02_04.text = "";

        ///////////////////////////////////////////////////////////////////////// 디테일 창 
        Detail_Order_Food_Script.Detail_Order_Food_Sprite_04_01.spriteName = "A_8";

        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_01.spriteName = "C_03_Idle_01";
        Detail_Order_Food_Script.Detail_Order_Need_Sprite_04_02.spriteName = "None";

        X_Sprite[9].spriteName = "Detail_Order_x";
        X_Sprite[10].spriteName = "None";
        X_Sprite[11].spriteName = "None";

        Detail_Order_Food_Script.Detail_Order_Need_Label_04_01.text = "1";
        Detail_Order_Food_Script.Detail_Order_Need_Label_04_02.text = "";

        Time_On_04_H();
    }






    // 1번자리 2번자리 3번자리 4번자리............
    public void Make_Order()
    {
        // 1번칸에 생성해야해!
        if (Order_01_Panel.alpha == 0f)
        {
            // 라운드 1 일 경우 
            int Random_Count = Random.Range(1, 8);

            if(Random_Count ==1)
            {
                Pop_Up_UI_01_A();
            }
            else if (Random_Count == 2)
            {
                Pop_Up_UI_01_B();
            }
            else if (Random_Count == 3)
            {
                Pop_Up_UI_01_C();
            }
            else if (Random_Count == 4)
            {
                Pop_Up_UI_01_D();
            }
            else if (Random_Count == 5)
            {
                Pop_Up_UI_01_E();
            }
            else if (Random_Count == 6)
            {
                Pop_Up_UI_01_F();
            }
            else if (Random_Count == 7)
            {
                Pop_Up_UI_01_G();
            }
            else if (Random_Count == 8)
            {
                Pop_Up_UI_01_H();
            }
          
            _Alart_Manager_Script.Set_Alart("[8ACE19]주문[-]이 접수되었습니다.");
            //[ff007e]
        }

        // 2번칸에 생성해야해!
        else if (Order_02_Panel.alpha == 0f)
        {
            // 라운드 1 일 경우 
            int Random_Count = Random.Range(1, 9);

            if (Random_Count == 1)
            {
                Pop_Up_UI_02_A();
            }
            else if (Random_Count == 2)
            {
                Pop_Up_UI_02_B();
            }
            else if (Random_Count == 3)
            {
                Pop_Up_UI_02_C();
            }
            else if (Random_Count == 4)
            {
                Pop_Up_UI_02_D();
            }
            else if (Random_Count == 5)
            {
                Pop_Up_UI_02_E();
            }
            else if (Random_Count == 6)
            {
                Pop_Up_UI_02_F();
            }
            else if (Random_Count == 7)
            {
                Pop_Up_UI_02_G();
            }
            else if (Random_Count == 8)
            {
                Pop_Up_UI_02_H();
            }

            _Alart_Manager_Script.Set_Alart("[8ACE19]주문[-]이 접수되었습니다.");
        }

        // 3번칸에 생성해야해!
        else if (Order_03_Panel.alpha == 0f)
        {
            // 라운드 1 일 경우 
            int Random_Count = Random.Range(1, 9);

            if (Random_Count == 1)
            {
                Pop_Up_UI_03_A();
            }
            else if (Random_Count == 2)
            {
                Pop_Up_UI_03_B();
            }
            else if (Random_Count == 3)
            {
                Pop_Up_UI_03_C();
            }
            else if (Random_Count == 4)
            {
                Pop_Up_UI_03_D();
            }
            else if (Random_Count == 5)
            {
                Pop_Up_UI_03_E();
            }
            else if (Random_Count == 6)
            {
                Pop_Up_UI_03_F();
            }
            else if (Random_Count == 7)
            {
                Pop_Up_UI_03_G();
            }
            else if (Random_Count == 8)
            {
                Pop_Up_UI_03_H();
            }

            _Alart_Manager_Script.Set_Alart("[8ACE19]주문[-]이 접수되었습니다.");
        }

        // 4번칸에 생성해야해!
        else if (Order_04_Panel.alpha == 0f)
        {
            // 라운드 1 일 경우 
            int Random_Count = Random.Range(1, 9);

            if (Random_Count == 1)
            {
                Pop_Up_UI_04_A();
            }
            else if (Random_Count == 2)
            {
                Pop_Up_UI_04_B();
            }
            else if (Random_Count == 3)
            {
                Pop_Up_UI_04_C();
            }
            else if (Random_Count == 4)
            {
                Pop_Up_UI_04_D();
            }
            else if (Random_Count == 5)
            {
                Pop_Up_UI_04_E();
            }
            else if (Random_Count == 6)
            {
                Pop_Up_UI_04_F();
            }
            else if (Random_Count == 7)
            {
                Pop_Up_UI_04_G();
            }
            else if (Random_Count == 8)
            {
                Pop_Up_UI_04_H();
            }

            _Alart_Manager_Script.Set_Alart("[8ACE19]주문[-]이 접수되었습니다.");
        }
    }




    // 타임바의 색상 변경
    private void IS_Time_Bar_01_Color()
    {
        if (Time_Bar_01.fillAmount <= 0.3f)
        {
            // 레드 색
            Time_Bar_01.color = new Color32(255, 66, 0, 255);
            Detail_UI_Time_Bar_01.color = new Color32(255, 66, 0, 255);
        }
        else if (Time_Bar_01.fillAmount <= 0.75f)
        {
            // 26년산 제주도 감귤 색
            Time_Bar_01.color = new Color32(255, 182, 0, 255);
            Detail_UI_Time_Bar_01.color = new Color32(255, 182, 0, 255);
        }
        else if (Time_Bar_01.fillAmount >= 0.9f)
        {
            // 그린 색
            Time_Bar_01.color = new Color32(0, 255, 0, 255);
            Detail_UI_Time_Bar_01.color = new Color32(0, 255, 0, 255);
        }
    }
    // 타임바의 색상 변경
    private void IS_Time_Bar_02_Color()
    {
        if (Time_Bar_02.fillAmount <= 0.3f)
        {
            // 레드 색
            Time_Bar_02.color = new Color32(255, 66, 0, 255);
            Detail_UI_Time_Bar_02.color = new Color32(255, 66, 0, 255);
        }
        else if (Time_Bar_02.fillAmount <= 0.75f)
        {
            // 26년산 제주도 감귤 색
            Time_Bar_02.color = new Color32(255, 182, 0, 255);
            Detail_UI_Time_Bar_02.color = new Color32(255, 182, 0, 255);
        }
        else if (Time_Bar_02.fillAmount >= 0.9f)
        {
            // 그린 색
            Time_Bar_02.color = new Color32(0, 255, 0, 255);
            Detail_UI_Time_Bar_02.color = new Color32(0, 255, 0, 255);
        }
    }
    // 타임바의 색상 변경
    private void IS_Time_Bar_03_Color()
    {
        if (Time_Bar_03.fillAmount <= 0.3f)
        {
            // 레드 색
            Time_Bar_03.color = new Color32(255, 66, 0, 255);
            Detail_UI_Time_Bar_03.color = new Color32(255, 66, 0, 255);
        }
        else if (Time_Bar_03.fillAmount <= 0.75f)
        {
            // 26년산 제주도 감귤 색
            Time_Bar_03.color = new Color32(255, 182, 0, 255);
            Detail_UI_Time_Bar_03.color = new Color32(255, 182, 0, 255);
        }
        else if (Time_Bar_03.fillAmount >= 0.9f)
        {
            // 그린 색
            Time_Bar_03.color = new Color32(0, 255, 0, 255);
            Detail_UI_Time_Bar_03.color = new Color32(0, 255, 0, 255);
        }
    }
    // 타임바의 색상 변경
    private void IS_Time_Bar_04_Color()
    {
        if (Time_Bar_04.fillAmount <= 0.3f)
        {
            // 레드 색
            Time_Bar_04.color = new Color32(255, 66, 0, 255);
            Detail_UI_Time_Bar_04.color = new Color32(255, 66, 0, 255);
        }
        else if (Time_Bar_04.fillAmount <= 0.75f)
        {
            // 26년산 제주도 감귤 색
            Time_Bar_04.color = new Color32(255, 182, 0, 255);
            Detail_UI_Time_Bar_04.color = new Color32(255, 182, 0, 255);
        }
        else if (Time_Bar_04.fillAmount >= 0.9f)
        {
            // 그린 색
            Time_Bar_04.color = new Color32(0, 255, 0, 255);
            Detail_UI_Time_Bar_04.color = new Color32(0, 255, 0, 255);
        }
    }


    



    // 주문서 창 판넬 끄기 + 색을 초기화 하기
    private void Turn_Off_Order_01()
    {
        Payed_01 = false;

        Order_01_Panel.alpha = 0f;
        Detail_Order_Food_Script.Detail_Order_01.alpha = 0f;

        Time_Bar_01.color = new Color32(0, 255, 0, 255);
    }
    private void Turn_Off_Order_02()
    {
        Payed_02 = false;

        Order_02_Panel.alpha = 0f;
        Detail_Order_Food_Script.Detail_Order_02.alpha = 0f;

        Time_Bar_02.color = new Color32(0, 255, 0, 255);
    }
    private void Turn_Off_Order_03()
    {
        Payed_03 = false;

        Order_03_Panel.alpha = 0f;
        Detail_Order_Food_Script.Detail_Order_03.alpha = 0f;

        Time_Bar_03.color = new Color32(0, 255, 0, 255);
    }
    private void Turn_Off_Order_04()
    {
        Payed_04 = false;

        Order_04_Panel.alpha = 0f;
        Detail_Order_Food_Script.Detail_Order_04.alpha = 0f;

        Time_Bar_04.color = new Color32(0, 255, 0, 255);
    }



    //open  close
    /*
    // UI창 이동 
    public void Open()
    {
        Vector3 next_Pos = new Vector3(0, 0, 0);
        Order_UI.position = Vector3.Lerp(Order_UI.position, next_Pos, 1f);

        Open_Close_Order_Ui_Box_Collider.enabled = false;
        Open_Close_Order_Ui_Button.SetState(UIButtonColor.State.Disabled, true);

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = true;
    }
    public void Close()
    {
        Vector3 next_Pos = new Vector3(-4, 0, 0);
        Order_UI.position = Vector3.Lerp(Order_UI.position, next_Pos, 1f);

        Open_Close_Order_Ui_Box_Collider.enabled = true;
        Open_Close_Order_Ui_Button.SetState(UIButtonColor.State.Normal, true);

        // 화면 전환 됨
        _Main_Cam_Script.Is_Cam_Stop = false;
    }
    */




    // 각 요리의 시간대 
    // 1번 레시피
    public void Time_On_01_A()
    {
        // 초기화
        Phase_Of_Order_01_A = 80;
        Phase_Of_Order_A_To_1 = Phase_Of_Order_01_A / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_A_To_1;

        StartCoroutine("Time_Flow_01_A");
    }
    public void Time_On_01_B()
    {
        // 초기화
        Phase_Of_Order_01_B = 80;
        Phase_Of_Order_B_To_1 = Phase_Of_Order_01_B / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_B_To_1;

        StartCoroutine("Time_Flow_01_B");
    }
    public void Time_On_01_C()
    {
        // 초기화
        Phase_Of_Order_01_C = 80;
        Phase_Of_Order_C_To_1 = Phase_Of_Order_01_C / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_C_To_1;

        StartCoroutine("Time_Flow_01_C");
    }
    public void Time_On_01_D()
    {
        // 초기화
        Phase_Of_Order_01_D = 80;
        Phase_Of_Order_D_To_1 = Phase_Of_Order_01_D / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_D_To_1;

        StartCoroutine("Time_Flow_01_D");
    }
    public void Time_On_01_E()
    {
        // 초기화 
        Phase_Of_Order_01_E = 80;
        Phase_Of_Order_E_To_1 = Phase_Of_Order_01_E / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_E_To_1;

        StartCoroutine("Time_Flow_01_E");
    }
    public void Time_On_01_F()
    {
        // 초기화 
        Phase_Of_Order_01_F = 80;
        Phase_Of_Order_F_To_1 = Phase_Of_Order_01_F / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_F_To_1;

        StartCoroutine("Time_Flow_01_F");
    }
    public void Time_On_01_G()
    {
        // 초기화 
        Phase_Of_Order_01_G = 80;
        Phase_Of_Order_G_To_1 = Phase_Of_Order_01_G / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_G_To_1;

        StartCoroutine("Time_Flow_01_G");
    }
    public void Time_On_01_H()
    {
        // 초기화 
        Phase_Of_Order_01_H = 80;
        Phase_Of_Order_H_To_1 = Phase_Of_Order_01_H / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_H_To_1;

        StartCoroutine("Time_Flow_01_H");
    }
    public void Time_On_01_I()
    {
        // 초기화 
        Phase_Of_Order_01_I = 80;
        Phase_Of_Order_I_To_1 = Phase_Of_Order_01_I / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_I_To_1;

        StartCoroutine("Time_Flow_01_I");
    }

    IEnumerator Time_Flow_01_A()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_A == 0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_A--;
        Phase_Of_Order_A_To_1 = Phase_Of_Order_01_A / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_A_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_A_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_A");
    }
    IEnumerator Time_Flow_01_B()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_B == 0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_B--;
        Phase_Of_Order_B_To_1 = Phase_Of_Order_01_B / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_B_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_B_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_B");
    }
    IEnumerator Time_Flow_01_C()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_C ==0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_C--;
        Phase_Of_Order_C_To_1 = Phase_Of_Order_01_C / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_C_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_C_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_C");
    }
    IEnumerator Time_Flow_01_D()
    {      
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_D == 0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_D--;
        Phase_Of_Order_D_To_1 = Phase_Of_Order_01_D / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_D_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_D_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_D");
    }
    IEnumerator Time_Flow_01_E()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_E == 0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_E--;
        Phase_Of_Order_E_To_1 = Phase_Of_Order_01_E / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_E_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_E_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_E");
    }
    IEnumerator Time_Flow_01_F()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_F ==0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_F--;
        Phase_Of_Order_F_To_1 = Phase_Of_Order_01_F / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_F_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_F_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_F");
    }
    IEnumerator Time_Flow_01_G()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_G ==0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_G--;
        Phase_Of_Order_G_To_1 = Phase_Of_Order_01_G / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_G_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_G_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_G");
    }
    IEnumerator Time_Flow_01_H()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_H ==0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_H--;
        Phase_Of_Order_H_To_1 = Phase_Of_Order_01_H / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_H_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_H_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_H");
    }
    IEnumerator Time_Flow_01_I()
    {
        // 타임바의 색상 변경
        IS_Time_Bar_01_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_01_I == 0)
        {
            Turn_Off_Order_01();
            yield break;
        }

        if (Payed_01 == true)
        {        
            Turn_Off_Order_01();
            yield break;
        }

        Phase_Of_Order_01_I--;
        Phase_Of_Order_I_To_1 = Phase_Of_Order_01_I / 80;
        Time_Bar_01.fillAmount = Phase_Of_Order_I_To_1;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_01.fillAmount = Phase_Of_Order_I_To_1;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_01_I");
    }

    // 2번 레시피
    public void Time_On_02_A()
    {
        // 초기화
        Phase_Of_Order_02_A = 80;
        Phase_Of_Order_A_To_2 = Phase_Of_Order_02_A / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_A_To_2;

        StartCoroutine("Time_Flow_02_A");
    }
    public void Time_On_02_B()
    {
        // 초기화 
        Phase_Of_Order_02_B = 80;
        Phase_Of_Order_B_To_2 = Phase_Of_Order_02_B / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_B_To_2;

        StartCoroutine("Time_Flow_02_B");
    }
    public void Time_On_02_C()
    {
        // 초기화 
        Phase_Of_Order_02_C = 80;
        Phase_Of_Order_C_To_2 = Phase_Of_Order_02_C / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_C_To_2;

        StartCoroutine("Time_Flow_02_C");
    }
    public void Time_On_02_D()
    {
        //초기화 
        Phase_Of_Order_02_D = 80;
        Phase_Of_Order_D_To_2 = Phase_Of_Order_02_D / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_D_To_2;

        StartCoroutine("Time_Flow_02_D");
    }
    public void Time_On_02_E()
    {
        Phase_Of_Order_02_E = 80;
        Phase_Of_Order_E_To_2 = Phase_Of_Order_02_E / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_E_To_2;

        StartCoroutine("Time_Flow_02_E");
    }
    public void Time_On_02_F()
    {
        Phase_Of_Order_02_F = 80;
        Phase_Of_Order_F_To_2 = Phase_Of_Order_02_F / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_F_To_2;

        StartCoroutine("Time_Flow_02_F");
    }
    public void Time_On_02_G()
    {
        Phase_Of_Order_02_G = 80;
        Phase_Of_Order_G_To_2 = Phase_Of_Order_02_G / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_G_To_2;

        StartCoroutine("Time_Flow_02_G");
    }
    public void Time_On_02_H()
    {
        Phase_Of_Order_02_H = 80;
        Phase_Of_Order_H_To_2 = Phase_Of_Order_02_H / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_H_To_2;

        StartCoroutine("Time_Flow_02_H");
    }
    public void Time_On_02_I()
    {
        Phase_Of_Order_02_I = 80;
        Phase_Of_Order_I_To_2 = Phase_Of_Order_02_I / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_I_To_2;

        StartCoroutine("Time_Flow_02_I");
    }

    IEnumerator Time_Flow_02_A()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_A == 0 )
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_A--;
        Phase_Of_Order_A_To_2 = Phase_Of_Order_02_A / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_A_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_A_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_A");
    }
    IEnumerator Time_Flow_02_B()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_B == 0)
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_B--;
        Phase_Of_Order_B_To_2 = Phase_Of_Order_02_B / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_B_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_B_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_B");
    }
    IEnumerator Time_Flow_02_C()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_C == 0)
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_C--;
        Phase_Of_Order_C_To_2 = Phase_Of_Order_02_C / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_C_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_C_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_C");
    }
    IEnumerator Time_Flow_02_D()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_D == 0)
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_D--;
        Phase_Of_Order_D_To_2 = Phase_Of_Order_02_D / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_D_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_D_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_D");
    }
    IEnumerator Time_Flow_02_E()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_E == 0 )
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_E--;
        Phase_Of_Order_E_To_2 = Phase_Of_Order_02_E / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_E_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_E_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_E");
    }
    IEnumerator Time_Flow_02_F()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_F == 0)
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_F--;
        Phase_Of_Order_F_To_2 = Phase_Of_Order_02_F / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_F_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_F_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_F");
    }
    IEnumerator Time_Flow_02_G()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_G == 0)
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_G--;
        Phase_Of_Order_G_To_2 = Phase_Of_Order_02_G / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_G_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_G_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_G");
    }
    IEnumerator Time_Flow_02_H()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_H ==0)
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_H--;
        Phase_Of_Order_H_To_2 = Phase_Of_Order_02_H / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_H_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_H_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_H");
    }
    IEnumerator Time_Flow_02_I()
    {
        IS_Time_Bar_02_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_02_I == 0)
        {
            Turn_Off_Order_02();
            yield break;
        }

        if (Payed_02 == true)
        {
            Turn_Off_Order_02();
            yield break;
        }

        Phase_Of_Order_02_I--;
        Phase_Of_Order_I_To_2 = Phase_Of_Order_02_I / 80;
        Time_Bar_02.fillAmount = Phase_Of_Order_I_To_2;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_02.fillAmount = Phase_Of_Order_I_To_2;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_02_I");
    }

    // 3번 레시피
    public void Time_On_03_A()
    {
        Phase_Of_Order_03_A = 80;
        Phase_Of_Order_A_To_3 = Phase_Of_Order_03_A / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_A_To_3;

        StartCoroutine("Time_Flow_03_A");
    }
    public void Time_On_03_B()
    {
        Phase_Of_Order_03_B = 80;
        Phase_Of_Order_B_To_3 = Phase_Of_Order_03_B / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_B_To_3;

        StartCoroutine("Time_Flow_03_B");
    }
    public void Time_On_03_C()
    {
        Phase_Of_Order_03_C = 80;
        Phase_Of_Order_C_To_3 = Phase_Of_Order_03_C / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_C_To_3;

        StartCoroutine("Time_Flow_03_C");
    }
    public void Time_On_03_D()
    {
        Phase_Of_Order_03_D = 80;
        Phase_Of_Order_D_To_3 = Phase_Of_Order_03_D / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_D_To_3;

        StartCoroutine("Time_Flow_03_D");
    }
    public void Time_On_03_E()
    {
        Phase_Of_Order_03_E = 80;
        Phase_Of_Order_E_To_3 = Phase_Of_Order_03_E / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_E_To_3;

        StartCoroutine("Time_Flow_03_E");
    }
    public void Time_On_03_F()
    {
        Phase_Of_Order_03_F = 80;
        Phase_Of_Order_F_To_3 = Phase_Of_Order_03_F / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_F_To_3;

        StartCoroutine("Time_Flow_03_F");
    }
    public void Time_On_03_G()
    {
        Phase_Of_Order_03_G = 80;
        Phase_Of_Order_G_To_3 = Phase_Of_Order_03_G / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_G_To_3;

        StartCoroutine("Time_Flow_03_G");
    }
    public void Time_On_03_H()
    {
        Phase_Of_Order_03_H = 80;
        Phase_Of_Order_H_To_3 = Phase_Of_Order_03_H / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_H_To_3;

        StartCoroutine("Time_Flow_03_H");
    }
    public void Time_On_03_I()
    {
        Phase_Of_Order_03_I = 80;
        Phase_Of_Order_I_To_3 = Phase_Of_Order_03_I / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_I_To_3;

        StartCoroutine("Time_Flow_03_I");
    }

    IEnumerator Time_Flow_03_A()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_A == 0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_A--;
        Phase_Of_Order_A_To_3 = Phase_Of_Order_03_A / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_A_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_A_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_A");
    }
    IEnumerator Time_Flow_03_B()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_B ==0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_B--;
        Phase_Of_Order_B_To_3 = Phase_Of_Order_03_B / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_B_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_B_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_B");
    }
    IEnumerator Time_Flow_03_C()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_C ==0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_C--;
        Phase_Of_Order_C_To_3 = Phase_Of_Order_03_C / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_C_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_C_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_C");
    }
    IEnumerator Time_Flow_03_D()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_D == 0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_D--;
        Phase_Of_Order_D_To_3 = Phase_Of_Order_03_D / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_D_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_D_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_D");
    }
    IEnumerator Time_Flow_03_E()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_E ==0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_E--;
        Phase_Of_Order_E_To_3 = Phase_Of_Order_03_E / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_E_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_E_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_E");
    }
    IEnumerator Time_Flow_03_F()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_F ==0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_F--;
        Phase_Of_Order_F_To_3 = Phase_Of_Order_03_F / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_F_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_F_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_F");
    }
    IEnumerator Time_Flow_03_G()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_G ==0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_G--;
        Phase_Of_Order_G_To_3 = Phase_Of_Order_03_G / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_G_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_G_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_G");
    }
    IEnumerator Time_Flow_03_H()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_H == 0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_H--;
        Phase_Of_Order_H_To_3 = Phase_Of_Order_03_H / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_H_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_H_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_H");
    }
    IEnumerator Time_Flow_03_I()
    {
        IS_Time_Bar_03_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_03_I ==0)
        {
            Turn_Off_Order_03();
            yield break;
        }

        if (Payed_03 == true)
        {
            Turn_Off_Order_03();
            yield break;
        }

        Phase_Of_Order_03_I--;
        Phase_Of_Order_I_To_3 = Phase_Of_Order_03_I / 80;
        Time_Bar_03.fillAmount = Phase_Of_Order_I_To_3;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_03.fillAmount = Phase_Of_Order_I_To_3;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_03_I");
    }

    // 4번 레시피
    public void Time_On_04_A()
    {
        Phase_Of_Order_04_A = 80;
        Phase_Of_Order_A_To_4 = Phase_Of_Order_04_A / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_A_To_4;

        StartCoroutine("Time_Flow_04_A");
    }
    public void Time_On_04_B()
    {            
        Phase_Of_Order_04_B = 80;
        Phase_Of_Order_B_To_4 = Phase_Of_Order_04_B / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_B_To_4;

        StartCoroutine("Time_Flow_04_B");
    }
    public void Time_On_04_C()
    {
        Phase_Of_Order_04_C = 80;
        Phase_Of_Order_C_To_4 = Phase_Of_Order_04_C / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_C_To_4;

        StartCoroutine("Time_Flow_04_C");
    }
    public void Time_On_04_D()
    {
        Phase_Of_Order_04_D = 80;
        Phase_Of_Order_D_To_4 = Phase_Of_Order_04_D / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_D_To_4;

        StartCoroutine("Time_Flow_04_D");
    }
    public void Time_On_04_E()
    {
        Phase_Of_Order_04_E = 80;
        Phase_Of_Order_E_To_4 = Phase_Of_Order_04_E / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_E_To_4;

        StartCoroutine("Time_Flow_04_E");
    }
    public void Time_On_04_F()
    {
        Phase_Of_Order_04_F = 80;
        Phase_Of_Order_F_To_4 = Phase_Of_Order_04_F / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_F_To_4;

        StartCoroutine("Time_Flow_04_F");
    }
    public void Time_On_04_G()
    {
        Phase_Of_Order_04_G = 80;
        Phase_Of_Order_G_To_4 = Phase_Of_Order_04_G / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_G_To_4;

        StartCoroutine("Time_Flow_04_G");
    }
    public void Time_On_04_H()
    {
        Phase_Of_Order_04_H = 80;
        Phase_Of_Order_H_To_4 = Phase_Of_Order_04_H / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_H_To_4;

        StartCoroutine("Time_Flow_04_H");
    }
    public void Time_On_04_I()
    {
        Phase_Of_Order_04_I = 80;
        Phase_Of_Order_I_To_4 = Phase_Of_Order_04_I / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_I_To_4;

        StartCoroutine("Time_Flow_04_I");
    }

    IEnumerator Time_Flow_04_A()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_A == 0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_A--;
        Phase_Of_Order_A_To_4 = Phase_Of_Order_04_A / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_A_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_A_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_A");
    }
    IEnumerator Time_Flow_04_B()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_B ==0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_B--;
        Phase_Of_Order_B_To_4 = Phase_Of_Order_04_B / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_B_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_B_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_B");
    }
    IEnumerator Time_Flow_04_C()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_C ==0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_C--;
        Phase_Of_Order_C_To_4 = Phase_Of_Order_04_C / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_C_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_C_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_C");
    }
    IEnumerator Time_Flow_04_D()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_D ==0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_D--;
        Phase_Of_Order_D_To_4 = Phase_Of_Order_04_D / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_D_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_D_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_D");
    }
    IEnumerator Time_Flow_04_E()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_E == 0)
        {
            Turn_Off_Order_04();
            yield break;
        }


        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_E--;
        Phase_Of_Order_E_To_4 = Phase_Of_Order_04_E / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_E_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_E_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_E");
    }
    IEnumerator Time_Flow_04_F()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_F ==0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_F--;
        Phase_Of_Order_F_To_4 = Phase_Of_Order_04_F / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_F_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_F_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_F");
    }
    IEnumerator Time_Flow_04_G()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_G ==0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_G--;
        Phase_Of_Order_G_To_4 = Phase_Of_Order_04_G / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_G_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_G_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_G");
    }
    IEnumerator Time_Flow_04_H()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_H ==0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_H--;
        Phase_Of_Order_H_To_4 = Phase_Of_Order_04_H / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_H_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_H_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_H");
    }
    IEnumerator Time_Flow_04_I()
    {
        IS_Time_Bar_04_Color();

        // 지정된 시간이 됬을 경우
        if (Phase_Of_Order_04_I ==0)
        {
            Turn_Off_Order_04();
            yield break;
        }

        if (Payed_04 == true)
        {
            Turn_Off_Order_04();
            yield break;
        }

        Phase_Of_Order_04_I--;
        Phase_Of_Order_I_To_4 = Phase_Of_Order_04_I / 80;
        Time_Bar_04.fillAmount = Phase_Of_Order_I_To_4;

        //커진화면에서 보여줄 시간 
        Detail_UI_Time_Bar_04.fillAmount = Phase_Of_Order_I_To_4;

        yield return new WaitForSeconds(1.5f);

        StartCoroutine("Time_Flow_04_I");
    }
}
