using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Detail_Order : MonoBehaviour {

    public UIPanel Detail_Order_01;
    public UIPanel Detail_Order_02;
    public UIPanel Detail_Order_03;
    public UIPanel Detail_Order_04;


    public UISprite Detail_Order_Food_Sprite_01_01;
    public UISprite Detail_Order_Need_Sprite_01_01;
    public UISprite Detail_Order_Need_Sprite_01_02;
    public UILabel Detail_Order_Need_Label_01_01;
    public UILabel Detail_Order_Need_Label_01_02;

    public UISprite Detail_Order_Food_Sprite_02_01;
    public UISprite Detail_Order_Need_Sprite_02_01;
    public UISprite Detail_Order_Need_Sprite_02_02;
    public UILabel Detail_Order_Need_Label_02_01;
    public UILabel Detail_Order_Need_Label_02_02;

    public UISprite Detail_Order_Food_Sprite_03_01;
    public UISprite Detail_Order_Need_Sprite_03_01;
    public UISprite Detail_Order_Need_Sprite_03_02;
    public UILabel Detail_Order_Need_Label_03_01;
    public UILabel Detail_Order_Need_Label_03_02;

    public UISprite Detail_Order_Food_Sprite_04_01;
    public UISprite Detail_Order_Need_Sprite_04_01;
    public UISprite Detail_Order_Need_Sprite_04_02;
    public UILabel Detail_Order_Need_Label_04_01;
    public UILabel Detail_Order_Need_Label_04_02;

    public Main_Cam _Main_Cam_Script;

    public Sound_Manager Sound_Man_Script;


    private void Awake()
    {
        Detail_Order_01.alpha = 0;
        Detail_Order_02.alpha = 0;
        Detail_Order_03.alpha = 0;
        Detail_Order_04.alpha = 0;
    }

    public void Open_Detai_01()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_01.alpha = 1f;

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = true;
    }
    public void Close_Detai_01()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_01.alpha = 0f;

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = false;
    }

    public void Open_Detai_02()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_02.alpha = 1f;

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = true;
    }
    public void Close_Detai_02()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_02.alpha = 0f;

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = false;
    }

    public void Open_Detai_03()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_03.alpha = 1f;

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = true;
    }
    public void Close_Detai_03()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_03.alpha = 0f;

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = false;
    }

    public void Open_Detai_04()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_04.alpha = 1f;

        // 화면 전환 안되게 하기
        _Main_Cam_Script.Is_Cam_Stop = true;
    }
    public void Close_Detai_04()
    {
        Sound_Man_Script.Play_Button_Click();
        Sound_Man_Script.Play_Scene_Change();

        Detail_Order_04.alpha = 0f;

        // 화면 전환 되게 하기
        _Main_Cam_Script.Is_Cam_Stop = false;
    }
}
