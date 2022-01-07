using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Buy_Button_11_03 : MonoBehaviour {

    public UIPanel Cha_Panel_;
    public UIPanel Button_01_02_03_04_Panel;

    public UISprite Box_Ui_Sprite;

    public UIButton Box_Ui_Button;
    public UIButton _Cha_Change_Normal_Image;

    public Cha_Grow_Up_11 Cha_Grow_Up;

    public Box_Change_Manager Box_Change_Man_Script;
    public Status_Manager _Player_Status_Script;
    public Alart_Manager _Alart_Manager_Script;
    public Shop_Script _Shop_Manager_Script;
    public Sound_Manager Sound_Man_Script;

    public UISpriteAnimation _UI_Sprite_Animation;




    /////////////////////////////////////////////////////////채소 타입
    // C_1타입의 가격 
    public int Unit_C_01_Price = 3000;

    // 이 버튼은 C_1 타입의 아이를 생성하기 위한 버튼입니다. 
    private string Button_01_Type = "C_01_Idle_01";
    private string Bg_01 = "Box_BG_01";



    private void Start()
    {
        Unit_C_01_Price = 3000;

        _UI_Sprite_Animation.enabled = false;
    }








    // 버튼클릭시 발동 
    public void Shop_Item_Make()
    {
        // 돈이 충분하다면 
        // 소지금으로 검사 
        if (Status_Manager.Money >= Unit_C_01_Price)
        {
            // 소지금 감소
            Status_Manager.Money -= Unit_C_01_Price;

            // 생성 함수
            Press_Button_Cha_Open_();
        }

        // 돈이 없어
        else if (Status_Manager.Money < Unit_C_01_Price)
        {
            // 돈이 없다는 알람 생성
            _Alart_Manager_Script.Set_Alart("돈이 부족합니다.");
            return;
        }
    }







    // 버튼 클릭시 캐릭터를 생성하고 해당 버튼에 맞게 생성한다.
    public void Press_Button_Cha_Open_()
    {
        // 캐릭터 변신
        Cha_Grow_Up.Cha.spriteName = Button_01_Type;
        _Cha_Change_Normal_Image.normalSprite = Button_01_Type;

        // 캐릭터의 타입 설정
        Cha_Grow_Up.Check_Cha_Name();

        // 행동 버튼 안보이게 하기 
        Button_01_02_03_04_Panel.alpha = 0f;

        Cha_Panel_.alpha = 1f;

        //애니메이션 설정 
        _UI_Sprite_Animation.enabled = true;
        _UI_Sprite_Animation.namePrefix = "C_01_Idle_";
        _UI_Sprite_Animation.framesPerSecond = 9;

        // 박스 변신 
        //박스 콜라이더 해제.
        Box_Change_Man_Script.Room_Collider_Off_11();

        // 채소방으로 이동
        Box_Change_Man_Script.Change_Room_To_Vegetable_Room_11();

        // 사운드 
        Sound_Man_Script.Loof_Play_Box_Cha_IS_Idle_11();
    }
}
