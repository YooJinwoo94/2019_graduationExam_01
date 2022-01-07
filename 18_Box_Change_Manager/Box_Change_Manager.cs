using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Change_Manager : MonoBehaviour {

    public BoxCollider[] Box_Collider_On_Off;
    public UIButton[] UiButton_On_Off;
    public UISprite[] Box_UI_Sprite;

    public UISpriteAnimation[] Box_UISpriteAni;

    public UISprite[] Cant_Open_Box_Sprite;
    public UISpriteAnimation[] Cant_Open_Box_Ani;

    public bool BOX_01;
    public bool BOX_02;
    public bool BOX_03;
    public bool BOX_04;
    public bool BOX_05;
    public bool BOX_06;
    public bool BOX_07;
    public bool BOX_08;
    public bool BOX_09;
    public bool BOX_10;
    public bool BOX_11;
    public bool BOX_12;


    //선택 전의 방 이미지 
    //?
    public string Num_Box_BG_00 = "Box_BG_00";
    //채소방
    private string Num_Box_BG_01 = "Box_BG_01";
    //고기방
    private string Num_Box_BG_02 = "Box_BG_02";
    // 해산물방 
    private string Num_Box_BG_03 = "Box_BG_03";
    // 기타방 
    private string Num_Box_BG_04 = "Box_BG_04";



    private void Awake()
    {
        for (int i = 0; i < 12; i++)
        {
            Box_UISpriteAni[i].enabled = false;
        }
    }



    //=============================================  채소방으로 채인지

    public void Change_Room_To_Vegetable_Room_01()
    {
        UiButton_On_Off[0].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[0].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[0].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_02()
    {
        UiButton_On_Off[1].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[1].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[1].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_03()
    {
        UiButton_On_Off[2].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[2].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[2].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_04()
    {
        UiButton_On_Off[3].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[3].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[3].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_05()
    {
        UiButton_On_Off[4].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[4].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[4].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_06()
    {
        UiButton_On_Off[5].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[5].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[5].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_07()
    {
        UiButton_On_Off[6].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[6].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[6].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_08()
    {
        UiButton_On_Off[7].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[7].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[7].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_09()
    {
        UiButton_On_Off[8].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[8].normalSprite = Num_Box_BG_01;
    
        Box_UI_Sprite[8].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_10()
    {
        UiButton_On_Off[9].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[9].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[9].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_11()
    {
        UiButton_On_Off[10].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[10].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[10].spriteName = Num_Box_BG_01;
    }

    public void Change_Room_To_Vegetable_Room_12()
    {
        UiButton_On_Off[11].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[11].normalSprite = Num_Box_BG_01;

        Box_UI_Sprite[11].spriteName = Num_Box_BG_01;
    }

    //=============================================   채소방으로 채인지




    //=============================================  고기방으로 채인지

    public void Change_Room_To_Meat_Room_01()
    {
        UiButton_On_Off[0].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[0].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[0].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_02()
    {
        UiButton_On_Off[1].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[1].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[1].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_03()
    {
        UiButton_On_Off[2].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[2].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[2].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_04()
    {
        UiButton_On_Off[3].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[3].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[3].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_05()
    {
        UiButton_On_Off[4].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[4].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[4].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_06()
    {
        UiButton_On_Off[5].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[5].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[5].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_07()
    {
        UiButton_On_Off[6].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[6].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[6].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_08()
    {
        UiButton_On_Off[7].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[7].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[7].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_09()
    {
        UiButton_On_Off[8].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[8].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[8].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_10()
    {
        UiButton_On_Off[9].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[9].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[9].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_11()
    {
        UiButton_On_Off[10].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[10].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[10].spriteName = Num_Box_BG_02;
    }

    public void Change_Room_To_Meat_Room_12()
    {
        UiButton_On_Off[11].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[11].normalSprite = Num_Box_BG_02;

        Box_UI_Sprite[11].spriteName = Num_Box_BG_02;
    }

    //=============================================   고기방으로 채인지





    //=============================================  해산물 방 

    public void Change_Room_To_Ocean_Room_01()
    {
        UiButton_On_Off[0].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[0].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[0].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_02()
    {
        UiButton_On_Off[1].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[1].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[1].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_03()
    {
        UiButton_On_Off[2].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[2].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[2].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_04()
    {
        UiButton_On_Off[3].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[3].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[3].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_05()
    {
        UiButton_On_Off[4].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[4].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[4].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_06()
    {
        UiButton_On_Off[5].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[5].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[5].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_07()
    {
        UiButton_On_Off[6].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[6].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[6].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_08()
    {
        UiButton_On_Off[7].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[7].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[7].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_09()
    {
        UiButton_On_Off[8].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[8].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[8].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_10()
    {
        UiButton_On_Off[9].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[9].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[9].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_11()
    {
        UiButton_On_Off[10].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[10].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[10].spriteName = Num_Box_BG_03;
    }

    public void Change_Room_To_Ocean_Room_12()
    {
        UiButton_On_Off[11].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[11].normalSprite = Num_Box_BG_03;

        Box_UI_Sprite[11].spriteName = Num_Box_BG_03;
    }

    //=============================================   해산물 방 






    //=============================================  기타방으로 체인지 

    public void Change_Room_To_Alt_Room_01()
    {
        UiButton_On_Off[0].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[0].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[0].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_02()
    {
        UiButton_On_Off[1].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[1].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[1].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_03()
    {
        UiButton_On_Off[2].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[2].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[2].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_04()
    {
        UiButton_On_Off[3].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[3].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[3].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_05()
    {
        UiButton_On_Off[4].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[4].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[4].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_06()
    {
        UiButton_On_Off[5].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[5].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[5].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_07()
    {
        UiButton_On_Off[6].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[6].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[6].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_08()
    {
        UiButton_On_Off[7].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[7].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[7].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_09()
    {
        UiButton_On_Off[8].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[8].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[8].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_10()
    {
        UiButton_On_Off[9].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[9].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[9].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_11()
    {
        UiButton_On_Off[10].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[10].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[10].spriteName = Num_Box_BG_04;
    }

    public void Change_Room_To_Alt_Room_12()
    {
        UiButton_On_Off[11].SetState(UIButtonColor.State.Normal, true);
        UiButton_On_Off[11].normalSprite = Num_Box_BG_04;

        Box_UI_Sprite[11].spriteName = Num_Box_BG_04;
    }

    //=============================================   기타방으로 체인지 






    //========================================================================================= 싸이렌 애니메이션  
    //=====================================================================================1
    public void Room_Siren_Ani_Vegetable_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[0].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[1].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[2].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[3].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[4].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[5].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[6].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[7].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[8].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[9].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[10].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Vegetable_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].namePrefix = "Box_Siren_01_";
        Box_UISpriteAni[11].framesPerSecond = 10;
    }
    //=====================================================================================

    //=====================================================================================2
    public void Room_Siren_Ani_Meat_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[0].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[1].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[2].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[3].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[4].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[5].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[6].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[7].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[8].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[9].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[10].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Meat_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].namePrefix = "Box_Siren_02_";
        Box_UISpriteAni[11].framesPerSecond = 10;
    }
    //=====================================================================================

    //=====================================================================================3
    public void Room_Siren_Ani_Ocean_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[0].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[1].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[2].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[3].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[4].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[5].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[6].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[7].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[8].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[9].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[10].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Ocean_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].namePrefix = "Box_Siren_03_";
        Box_UISpriteAni[11].framesPerSecond = 10;
    }
    //=====================================================================================

    //=====================================================================================4
    public void Room_Siren_Ani_Alt_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[0].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[1].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[2].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[3].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[4].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[5].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[6].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[7].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[8].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[9].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[10].framesPerSecond = 10;
    }
    public void Room_Siren_Ani_Alt_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].namePrefix = "Box_Siren_04_";
        Box_UISpriteAni[11].framesPerSecond = 10;
    }
    //=====================================================================================
    //========================================================================================= 싸이렌 애니메이션  








    public void Room_Shelter_Vegetable_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].loop = false;
        Box_UISpriteAni[0].namePrefix = "Shelter_01_";
        Box_UISpriteAni[0].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].loop = false;
        Box_UISpriteAni[1].namePrefix = "Shelter_01_";
        Box_UISpriteAni[1].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].loop = false;
        Box_UISpriteAni[2].namePrefix = "Shelter_01_";
        Box_UISpriteAni[2].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].loop = false;
        Box_UISpriteAni[3].namePrefix = "Shelter_01_";
        Box_UISpriteAni[3].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].loop = false;
        Box_UISpriteAni[4].namePrefix = "Shelter_01_";
        Box_UISpriteAni[4].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].loop = false;
        Box_UISpriteAni[5].namePrefix = "Shelter_01_";
        Box_UISpriteAni[5].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].loop = false;
        Box_UISpriteAni[6].namePrefix = "Shelter_01_";
        Box_UISpriteAni[6].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].loop = false;
        Box_UISpriteAni[7].namePrefix = "Shelter_01_";
        Box_UISpriteAni[7].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].loop = false;
        Box_UISpriteAni[8].namePrefix = "Shelter_01_";
        Box_UISpriteAni[8].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].loop = false;
        Box_UISpriteAni[9].namePrefix = "Shelter_01_";
        Box_UISpriteAni[9].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].loop = false;
        Box_UISpriteAni[10].namePrefix = "Shelter_01_";
        Box_UISpriteAni[10].framesPerSecond = 7;
    }
    public void Room_Shelter_Vegetable_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].loop = false;
        Box_UISpriteAni[11].namePrefix = "Shelter_01_";
        Box_UISpriteAni[11].framesPerSecond = 7;
    }



    public void Room_Shelter_Meat_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].loop = false;
        Box_UISpriteAni[0].namePrefix = "Shelter_02_";
        Box_UISpriteAni[0].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].loop = false;
        Box_UISpriteAni[1].namePrefix = "Shelter_02_";
        Box_UISpriteAni[1].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].loop = false;
        Box_UISpriteAni[2].namePrefix = "Shelter_02_";
        Box_UISpriteAni[2].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].loop = false;
        Box_UISpriteAni[3].namePrefix = "Shelter_02_";
        Box_UISpriteAni[3].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].loop = false;
        Box_UISpriteAni[4].namePrefix = "Shelter_02_";
        Box_UISpriteAni[4].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].loop = false;
        Box_UISpriteAni[5].namePrefix = "Shelter_02_";
        Box_UISpriteAni[5].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].loop = false;
        Box_UISpriteAni[6].namePrefix = "Shelter_02_";
        Box_UISpriteAni[6].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].loop = false;
        Box_UISpriteAni[7].namePrefix = "Shelter_02_";
        Box_UISpriteAni[7].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].loop = false;
        Box_UISpriteAni[8].namePrefix = "Shelter_02_";
        Box_UISpriteAni[8].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].loop = false;
        Box_UISpriteAni[9].namePrefix = "Shelter_02_";
        Box_UISpriteAni[9].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].loop = false;
        Box_UISpriteAni[10].namePrefix = "Shelter_02_";
        Box_UISpriteAni[10].framesPerSecond = 7;
    }
    public void Room_Shelter_Meat_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].loop = false;
        Box_UISpriteAni[11].namePrefix = "Shelter_02_";
        Box_UISpriteAni[11].framesPerSecond = 7;
    }



    public void Room_Shelter_Ocean_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].loop = false;
        Box_UISpriteAni[0].namePrefix = "Shelter_03_";
        Box_UISpriteAni[0].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].loop = false;
        Box_UISpriteAni[1].namePrefix = "Shelter_03_";
        Box_UISpriteAni[1].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].loop = false;
        Box_UISpriteAni[2].namePrefix = "Shelter_03_";
        Box_UISpriteAni[2].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].loop = false;
        Box_UISpriteAni[3].namePrefix = "Shelter_03_";
        Box_UISpriteAni[3].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].loop = false;
        Box_UISpriteAni[4].namePrefix = "Shelter_03_";
        Box_UISpriteAni[4].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].loop = false;
        Box_UISpriteAni[5].namePrefix = "Shelter_03_";
        Box_UISpriteAni[5].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].loop = false;
        Box_UISpriteAni[6].namePrefix = "Shelter_03_";
        Box_UISpriteAni[6].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].loop = false;
        Box_UISpriteAni[7].namePrefix = "Shelter_03_";
        Box_UISpriteAni[7].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].loop = false;
        Box_UISpriteAni[8].namePrefix = "Shelter_03_";
        Box_UISpriteAni[8].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].loop = false;
        Box_UISpriteAni[9].namePrefix = "Shelter_03_";
        Box_UISpriteAni[9].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].loop = false;
        Box_UISpriteAni[10].namePrefix = "Shelter_03_";
        Box_UISpriteAni[10].framesPerSecond = 7;
    }
    public void Room_Shelter_Ocean_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].loop = false;
        Box_UISpriteAni[11].namePrefix = "Shelter_03_";
        Box_UISpriteAni[11].framesPerSecond = 7;
    }



    public void Room_Shelter_Alt_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = true;
        Box_UISpriteAni[0].loop = false;
        Box_UISpriteAni[0].namePrefix = "Shelter_04_";
        Box_UISpriteAni[0].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = true;
        Box_UISpriteAni[1].loop = false;
        Box_UISpriteAni[1].namePrefix = "Shelter_04_";
        Box_UISpriteAni[1].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = true;
        Box_UISpriteAni[2].loop = false;
        Box_UISpriteAni[2].namePrefix = "Shelter_04_";
        Box_UISpriteAni[2].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = true;
        Box_UISpriteAni[3].loop = false;
        Box_UISpriteAni[3].namePrefix = "Shelter_04_";
        Box_UISpriteAni[3].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = true;
        Box_UISpriteAni[4].loop = false;
        Box_UISpriteAni[4].namePrefix = "Shelter_04_";
        Box_UISpriteAni[4].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = true;
        Box_UISpriteAni[5].loop = false;
        Box_UISpriteAni[5].namePrefix = "Shelter_04_";
        Box_UISpriteAni[5].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = true;
        Box_UISpriteAni[6].loop = false;
        Box_UISpriteAni[6].namePrefix = "Shelter_04_";
        Box_UISpriteAni[6].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = true;
        Box_UISpriteAni[7].loop = false;
        Box_UISpriteAni[7].namePrefix = "Shelter_04_";
        Box_UISpriteAni[7].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = true;
        Box_UISpriteAni[8].loop = false;
        Box_UISpriteAni[8].namePrefix = "Shelter_04_";
        Box_UISpriteAni[8].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = true;
        Box_UISpriteAni[9].loop = false;
        Box_UISpriteAni[9].namePrefix = "Shelter_04_";
        Box_UISpriteAni[9].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = true;
        Box_UISpriteAni[10].loop = false;
        Box_UISpriteAni[10].namePrefix = "Shelter_04_";
        Box_UISpriteAni[10].framesPerSecond = 7;
    }
    public void Room_Shelter_Alt_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = true;
        Box_UISpriteAni[11].loop = false;
        Box_UISpriteAni[11].namePrefix = "Shelter_04_";
        Box_UISpriteAni[11].framesPerSecond = 7;
    }







    //========================================================================================= 정지 
    //=====================================================================================1
    public void Stop_Room_Siren_Ani_Vegetable_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Vegetable_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = false;
    }
    //=====================================================================================

    //=====================================================================================2
    public void Stop_Room_Siren_Ani_Meat_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Meat_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = false;
    }
    //=====================================================================================

    //=====================================================================================3
    public void Stop_Room_Siren_Ani_Ocean_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Ocean_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = false;
    }
    //=====================================================================================

    //=====================================================================================4
    public void Stop_Room_Siren_Ani_Alt_Room_01()
    {
        //애니메이션 설정 
        Box_UISpriteAni[0].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_02()
    {
        //애니메이션 설정 
        Box_UISpriteAni[1].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_03()
    {
        //애니메이션 설정 
        Box_UISpriteAni[2].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_04()
    {
        //애니메이션 설정 
        Box_UISpriteAni[3].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_05()
    {
        //애니메이션 설정 
        Box_UISpriteAni[4].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_06()
    {
        //애니메이션 설정 
        Box_UISpriteAni[5].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_07()
    {
        //애니메이션 설정 
        Box_UISpriteAni[6].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_08()
    {
        //애니메이션 설정 
        Box_UISpriteAni[7].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_09()
    {
        //애니메이션 설정 
        Box_UISpriteAni[8].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_10()
    {
        //애니메이션 설정 
        Box_UISpriteAni[9].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_11()
    {
        //애니메이션 설정 
        Box_UISpriteAni[10].enabled = false;
    }
    public void Stop_Room_Siren_Ani_Alt_Room_12()
    {
        //애니메이션 설정 
        Box_UISpriteAni[11].enabled = false;
    }
    //=====================================================================================
    //========================================================================================= 정지  













    //========================================================================================= 스프라이트 정상화  
    //=====================================================================================1
    public void Sprite_Reset_01()
    {
        // 채소방 
        if(Box_UI_Sprite[0].spriteName == "Box_Siren_01_01"|| Box_UI_Sprite[0].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[0].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[0].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[0].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[0].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[0].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[0].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if( Box_UI_Sprite[0].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[0].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[0].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[0].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[0].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[0].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[0].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[0].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_02()
    {
        // 채소방 
        if (Box_UI_Sprite[1].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[1].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[1].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[1].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[1].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[1].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[1].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[1].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[1].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[1].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[1].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[1].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[1].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[1].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[1].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[1].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_03()
    {
        // 채소방 
        if (Box_UI_Sprite[2].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[2].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[2].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[2].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[2].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[2].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[2].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[2].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[2].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[2].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[2].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[2].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[2].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[2].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[2].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[2].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_04()
    {
        // 채소방 
        if (Box_UI_Sprite[3].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[3].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[3].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[3].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[3].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[3].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[3].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[3].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[3].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[3].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[3].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[3].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[3].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[3].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[3].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[3].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_05()
    {
        // 채소방 
        if (Box_UI_Sprite[4].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[4].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[4].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[4].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[4].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[4].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[4].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[4].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[4].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[4].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[4].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[4].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[4].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[4].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[4].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[4].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_06()
    {
        // 채소방 
        if (Box_UI_Sprite[5].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[5].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[5].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[5].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[5].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[5].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[5].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[5].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[5].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[5].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[5].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[5].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[5].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[5].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[5].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[5].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_07()
    {
        // 채소방 
        if (Box_UI_Sprite[6].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[6].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[6].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[6].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[6].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[6].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[6].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[6].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[6].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[6].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[6].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[6].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[6].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[6].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[6].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[6].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_08()
    {
        // 채소방 
        if (Box_UI_Sprite[7].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[7].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[7].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[7].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[7].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[7].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[7].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[7].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[7].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[7].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[7].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[7].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[7].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[7].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[7].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[7].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_09()
    {
        // 채소방 
        if (Box_UI_Sprite[8].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[8].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[8].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[8].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[8].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[8].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[8].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[8].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[8].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[8].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[8].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[8].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[8].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[8].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[8].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[8].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_10()
    {
        // 채소방 
        if (Box_UI_Sprite[9].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[9].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[9].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[9].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[9].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[9].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[9].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[9].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[9].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[9].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[9].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[9].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[9].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[9].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[9].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[9].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_11()
    {
        // 채소방 
        if (Box_UI_Sprite[10].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[10].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[10].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[10].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[10].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[10].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[10].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[10].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[10].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[10].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[10].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[10].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[10].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[10].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[10].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[10].spriteName = "Box_BG_04";
        }
    }
    public void Sprite_Reset_12()
    {
        // 채소방 
        if (Box_UI_Sprite[11].spriteName == "Box_Siren_01_01" || Box_UI_Sprite[11].spriteName == "Box_Siren_01_02" || Box_UI_Sprite[11].spriteName == "Box_Siren_01_03")
        {
            Box_UI_Sprite[11].spriteName = "Box_BG_01";
        }

        // 고기방 
        else if (Box_UI_Sprite[11].spriteName == "Box_Siren_02_01" || Box_UI_Sprite[11].spriteName == "Box_Siren_02_02" || Box_UI_Sprite[11].spriteName == "Box_Siren_02_03")
        {
            Box_UI_Sprite[11].spriteName = "Box_BG_02";
        }

        // 해산물 방 
        else if (Box_UI_Sprite[11].spriteName == "Box_Siren_03_01" || Box_UI_Sprite[11].spriteName == "Box_Siren_03_02" || Box_UI_Sprite[11].spriteName == "Box_Siren_03_03")
        {
            Box_UI_Sprite[11].spriteName = "Box_BG_03";
        }

        // 기타 방 
        else if (Box_UI_Sprite[11].spriteName == "Box_Siren_04_01" || Box_UI_Sprite[11].spriteName == "Box_Siren_04_02" || Box_UI_Sprite[11].spriteName == "Box_Siren_04_03")
        {
            Box_UI_Sprite[11].spriteName = "Box_BG_04";
        }
    }
    //=====================================================================================














    //=============================================  방 리셋

    public void Room_Reset_01()
    {
        Stop_Room_Siren_Ani_Meat_Room_01();

        Box_Collider_On_Off[0].enabled = true;
        UiButton_On_Off[0].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[0].spriteName = Num_Box_BG_00;
        UiButton_On_Off[0].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_02()
    {
        Stop_Room_Siren_Ani_Meat_Room_02();

        Box_Collider_On_Off[1].enabled = true;
        UiButton_On_Off[1].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[1].spriteName = Num_Box_BG_00;
        UiButton_On_Off[1].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_03()
    {
        Stop_Room_Siren_Ani_Meat_Room_03();

        Box_Collider_On_Off[2].enabled = true;
        UiButton_On_Off[2].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[2].spriteName = Num_Box_BG_00;
        UiButton_On_Off[2].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_04()
    {
        Stop_Room_Siren_Ani_Meat_Room_04();

        Box_Collider_On_Off[3].enabled = true;
        UiButton_On_Off[3].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[3].spriteName = Num_Box_BG_00;
        UiButton_On_Off[3].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_05()
    {
        Stop_Room_Siren_Ani_Meat_Room_05();

        Box_Collider_On_Off[4].enabled = true;
        UiButton_On_Off[4].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[4].spriteName = Num_Box_BG_00;
        UiButton_On_Off[4].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_06()
    {
        Stop_Room_Siren_Ani_Meat_Room_06();

        Box_Collider_On_Off[5].enabled = true;
        UiButton_On_Off[5].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[5].spriteName = Num_Box_BG_00;
        UiButton_On_Off[5].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_07()
    {
        Stop_Room_Siren_Ani_Meat_Room_07();

        Box_Collider_On_Off[6].enabled = true;
        UiButton_On_Off[6].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[6].spriteName = Num_Box_BG_00;
        UiButton_On_Off[6].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_08()
    {
        Stop_Room_Siren_Ani_Meat_Room_08();

        Box_Collider_On_Off[7].enabled = true;
        UiButton_On_Off[7].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[7].spriteName = Num_Box_BG_00;
        UiButton_On_Off[7].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_09()
    {
        Stop_Room_Siren_Ani_Meat_Room_09();

        Box_Collider_On_Off[8].enabled = true;
        UiButton_On_Off[8].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[8].spriteName = Num_Box_BG_00;
        UiButton_On_Off[8].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_10()
    {
        Stop_Room_Siren_Ani_Meat_Room_10();

        Box_Collider_On_Off[9].enabled = true;
        UiButton_On_Off[9].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[9].spriteName = Num_Box_BG_00;
        UiButton_On_Off[9].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_11()
    {
        Stop_Room_Siren_Ani_Meat_Room_11();

        Box_Collider_On_Off[10].enabled = true;
        UiButton_On_Off[10].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[10].spriteName = Num_Box_BG_00;
        UiButton_On_Off[10].normalSprite = Num_Box_BG_00;
    }

    public void Room_Reset_12()
    {
        Stop_Room_Siren_Ani_Meat_Room_12();

        Box_Collider_On_Off[11].enabled = true;
        UiButton_On_Off[11].SetState(UIButtonColor.State.Normal, true);

        Box_UI_Sprite[11].spriteName = Num_Box_BG_00;
        UiButton_On_Off[11].normalSprite = Num_Box_BG_00;
    }

    //=============================================  방 리셋 




    //=============================================  방 일시적으로 콜라이더 잠금 

    public void Room_Collider_Off_01()
    {
        Box_Collider_On_Off[0].enabled = false;
    }

    public void Room_Collider_Off_02()
    {
        Box_Collider_On_Off[1].enabled = false;
    }

    public void Room_Collider_Off_03()
    {
        Box_Collider_On_Off[2].enabled = false;
    }

    public void Room_Collider_Off_04()
    {
        Box_Collider_On_Off[3].enabled = false;
    }

    public void Room_Collider_Off_05()
    {
        Box_Collider_On_Off[4].enabled = false;
    }

    public void Room_Collider_Off_06()
    {
        Box_Collider_On_Off[5].enabled = false;
    }

    public void Room_Collider_Off_07()
    {
        Box_Collider_On_Off[6].enabled = false;
    }

    public void Room_Collider_Off_08()
    {
        Box_Collider_On_Off[7].enabled = false;
    }

    public void Room_Collider_Off_09()
    {
        Box_Collider_On_Off[8].enabled = false;
    }

    public void Room_Collider_Off_10()
    {
        Box_Collider_On_Off[9].enabled = false;
    }

    public void Room_Collider_Off_11()
    {
        Box_Collider_On_Off[10].enabled = false;
    }

    public void Room_Collider_Off_12()
    {
        Box_Collider_On_Off[11].enabled = false;
    }

    //=============================================  방 일시적으로 콜라이더 잠금 
}
